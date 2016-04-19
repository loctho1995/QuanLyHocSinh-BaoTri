alter table hocsinh add TONGIAO varchar(30)
alter table hocsinh add HOTENCHAC varchar(30)
alter table hocsinh add HOTENME varchar(30)
alter table hocsinh add NGHENGHIEPME varchar(30)
alter table hocsinh add NGHENGHIEPCHA varchar(30)
alter table lop add MATRGLOP int foreign key references hocsinh(MAHS)
ALTER TABLE LOP ADD MAGVCN CHAR (5) FOREIGN KEY REFERENCES GIAOVIEN(MAGV)
ALTER TABLE PHANLOP ADD FOREIGN KEY (MAHS) REFERENCES HOCSINH(MAHS)
alter table monhoc add  MAGV CHAR(5) FOREIGN KEY REFERENCES GIAOVIEN(MAGV)

create table GIAOVIEN(
	MAGV CHAR(5) PRIMARY KEY,
	HOTEN NVARCHAR(20),
	NGAYSINH SMALLDATETIME,
	GIOITINH CHAR (3),
	SODT VARCHAR(11)
)
drop table giaovien
alter table giangday add  MAGV char(5) foreign key references giaovien(magv)
DROP TABLE GIAOVIEN
--phân quyền, đăng nhập
CREATE TABLE USERS(
	ID CHAR(5) PRIMARY KEY,
	PASSWORD VARCHAR(30),
	EMAIL VARCHAR(40),
	PHANQUYEN INT
	FOREIGN KEY (ID) REFERENCES GIAOVIEN(MAGV)
)
DROP TABLE USERS
--thêm table qui định
CREATE TABLE QUIDINH(
	TUOITOITHIEU INT,
	TUOITOIDA INT,
	SISOTOITHIEU INT,
	SISOTOIDA INT,
	DIEMTOITHIEU FLOAT,
	DIEMTOIDA FLOAT
)

CREATE TABLE DIEMTBHOCKY( 
	MAHS INT FOREIGN KEY REFERENCES HOCSINH(MAHS),
	MALOP CHAR(5) FOREIGN KEY REFERENCES LOP(MALOP),
	MALOAIDIEM VARCHAR(7) FOREIGN KEY REFERENCES LOAIDIEM(MALOAIDIEM),
	DIEM FLOAT,
	MANAMHOC INT FOREIGN KEY REFERENCES NAMHOC(MANAMHOC)
)

CREATE TABLE GIANGDAY(
	MALOP CHAR(5) FOREIGN KEY REFERENCES LOP(MALOP),
	MAMONHOC VARCHAR(10) FOREIGN KEY REFERENCES MONHOC(MAMONHOC),
	MANAMHOC INT FOREIGN KEY REFERENCES NAMHOC(MANAMHOC),
	HOCKY CHAR(2) FOREIGN KEY REFERENCES HOCKY(MAHOCKY),
	NGAYBATDAU SMALLDATETIME,
	NGAYKETTHUC SMALLDATETIME,
	GHICHU NVARCHAR(200)
	PRIMARY KEY(MALOP,MAMONHOC,MANAMHOC,HOCKY)
)

CREATE TABLE CAIDAT(
	MAIN_BACKCOLOR VARCHAR(20),
	TOPBUTTONCOLOR VARCHAR(20),
	TABBUTTONCOLOR VARCHAR(20),
	SEACHCONTROL_BACKGOUND VARCHAR(20),
)
--luu du lieu cua setting vao database
create proc sp_InsertDuLieuCaiDat(@main_backcolor varchar(50), @topbuttoncolor varchar(50),@tabbuttoncolor varchar(50),@seachcontrol_background varchar(50), @tabpanel_color varchar(50))
AS
	BEGIN
		IF NOT EXISTS (SELECT * FROM CAIDAT)
			INSERT INTO CAIDAT VALUES(@main_backcolor, @topbuttoncolor, @tabbuttoncolor, @seachcontrol_background, @tabpanel_color)
		ELSE BEGIN
			UPDATE CAIDAT
			SET MAIN_BACKCOLOR = @main_backcolor,
				TOPBUTTONCOLOR = @topbuttoncolor,
				TABBUTTONCOLOR = @tabbuttoncolor,
				SEACHCONTROL_BACKGOUND = @seachcontrol_background,
				TABPANEL_COLOR = @tabpanel_color
		END
	END	
--ràng buộc về tuổi
CREATE TRIGGER T_TUOI ON HOCSINH
FOR UPDATE, INSERT
AS
	DECLARE @tuoitoithieu int,
			@tuoitoida int,
			@ngaysinh smalldatetime,
			@tuoi int
	SELECT @tuoitoida = TUOITOIDA, @tuoitoithieu = TUOITOITHIEU FROM QUIDINH
	SELECT @ngaysinh = NGAYSINH FROM inserted
	IF((MONTH(GETDATE())>MONTH(@ngaysinh))OR(MONTH(GETDATE())=MONTH(@ngaysinh) AND DAY(GETDATE())>=DAY(@ngaysinh)))
	BEGIN
		SET @tuoi = YEAR(GETDATE()) - YEAR(@ngaysinh)
	END
	ELSE SET @tuoi = YEAR(GETDATE()) - YEAR(@ngaysinh) -1
	IF(@tuoi<@tuoitoithieu OR @tuoi > @tuoitoida)
	BEGIN
		RAISERROR('Tuổi không hợp lệ', 16,1);
		ROLLBACK TRANSACTION 
	END


--ràng buộc về sĩ số của lớp
CREATE TRIGGER T_SISOLOP ON PHANLOP
FOR INSERT, UPDATE
AS
	DECLARE @sisotoithieu int,
			@sisotoida int,
			@sisohientai int,
			@malop char(5)
	SELECT @malop = MALOP FROM inserted
	SELECT @sisotoithieu = SISOTOITHIEU ,@sisotoida = SISOTOIDA FROM QUIDINH
	SELECT @sisohientai = COUNT(MAHS) FROM PHANLOP WHERE MALOP = @malop
									  GROUP BY MALOP
	IF(@sisohientai>@sisotoida OR @sisohientai <@sisotoithieu)
	BEGIN
		RAISERROR('Lớp đầy!',16,2);
		ROLLBACK TRANSACTION
	END

--database quản lý điểm
--tinh diem trung binh theo mon hoc ky 1
CREATE TRIGGER T_DiemTBHocKy1 ON DIEMHOCKY1
FOR UPDATE, INSERT
AS	
	DECLARE @mahs int,
			@mamonhoc varchar(10),
			@manamhoc int,
			@malop char(5),
			@maloaidiem varchar(7),
			@diem float,
			@diemtbmon float,
			@heso SMALLint,
			@diemtoithieu float,
			@diemtoida float,
			@diemcu float
	SELECT @diemtoithieu = DIEMTOITHIEU,@diemtoida = DIEMTOIDA FROM QUIDINH
	SELECT @mahs= MAHS, @mamonhoc = MAMONHOC, @manamhoc = MANAMHOC, @malop = MALOP, @maloaidiem = MALOAIDIEM, @diem = DIEM  FROM inserted
	SELECT @diemtbmon = DIEM FROM DIEMHOCKY1 WHERE MAHS = @mahs AND  MALOAIDIEM = 'LD0007' AND MAMONHOC = @mamonhoc
	SELECT @heso = HESO FROM LOAIDIEM WHERE MALOAIDIEM = @maloaidiem
	BEGIN
		IF(@diem<@diemtoithieu OR @diem>@diemtoida) BEGIN
			RAISERROR('DIEM HKONG HOP LE',16,3)
			ROLLBACK TRANSACTION
		END

		IF(@diemtbmon IS NULL)
			SET @diemtbmon =0 

		IF(EXISTS (SELECT* FROM deleted WHERE MAHS = @mahs AND MAMONHOC = @mamonhoc AND MALOP = @malop AND MALOAIDIEM = @maloaidiem)) BEGIN
			SELECT @diemcu = DIEM FROM deleted WHERE MAHS = @mahs AND MAMONHOC = @mamonhoc AND MALOP = @malop AND MALOAIDIEM = @maloaidiem
		END
		ELSE SET @diemcu =0

		SET @diemtbmon = @diemtbmon + @heso*@diem/7 - @diemcu*@heso/7

		IF(NOT EXISTS(SELECT * FROM DIEMHOCKY1 WHERE MAHS = @mahs AND MAMONHOC= @mamonhoc AND MALOAIDIEM = 'LD0007' AND MANAMHOC = @manamhoc))
			INSERT INTO DIEMHOCKY1 VALUES(@mahs,@mamonhoc, @manamhoc, @malop, 'LD0007', @diemtbmon)
		ELSE BEGIN
			UPDATE DIEMHOCKY1
			SET DIEM = @diemtbmon
			WHERE MALOAIDIEM = 'LD0007' AND MAMONHOC = @mamonhoc AND MAHS = @mahs AND MANAMHOC = @manamhoc AND MALOP = @malop
		END
	END


--tinh diem trung binh theo mon hoc ky 2
CREATE TRIGGER T_DiemTBHocKy2 ON DIEMHOCKY2
FOR UPDATE, INSERT
AS	
	DECLARE @mahs int,
			@mamonhoc varchar(10),
			@manamhoc int,
			@malop char(5),
			@maloaidiem varchar(7),
			@diem float,
			@diemtbmon float,
			@heso SMALLint,
			@diemtoithieu float,
			@diemtoida float,
			@diemcu float
	SELECT @diemtoithieu = DIEMTOITHIEU,@diemtoida = DIEMTOIDA FROM QUIDINH
	SELECT @mahs= MAHS, @mamonhoc = MAMONHOC, @manamhoc = MANAMHOC, @malop = MALOP, @maloaidiem = MALOAIDIEM, @diem = DIEM  FROM inserted
	SELECT @diemtbmon = DIEM FROM DIEMHOCKY2 WHERE MAHS = @mahs AND  MALOAIDIEM = 'LD0008' AND MAMONHOC = @mamonhoc
	SELECT @heso = HESO FROM LOAIDIEM WHERE MALOAIDIEM = @maloaidiem
	BEGIN
		IF(@diem<@diemtoithieu OR @diem>@diemtoida) BEGIN
			RAISERROR('DIEM KHONG HOP LE',16,3)
			ROLLBACK TRANSACTION
		END

		IF(@diemtbmon IS NULL)
			SET @diemtbmon =0 

		IF(EXISTS (SELECT* FROM deleted WHERE MAHS = @mahs AND MAMONHOC = @mamonhoc AND MALOP = @malop AND MALOAIDIEM = @maloaidiem)) BEGIN
			SELECT @diemcu = DIEM FROM deleted WHERE MAHS = @mahs AND MAMONHOC = @mamonhoc AND MALOP = @malop AND MALOAIDIEM = @maloaidiem
		END
		ELSE SET @diemcu =0
		print @diemtbmon
		SET @diemtbmon = @diemtbmon + @heso*@diem/7 - @diemcu*@heso/7
		print @diem
		print @diemcu
		print @diemtbmon
		IF(NOT EXISTS(SELECT * FROM DIEMHOCKY2 WHERE MAHS = @mahs AND MAMONHOC= @mamonhoc AND MALOAIDIEM = 'LD0008' AND MANAMHOC = @manamhoc))
			INSERT INTO DIEMHOCKY2 VALUES(@mahs,@mamonhoc, @manamhoc, @malop, 'LD0008', @diemtbmon)
		ELSE BEGIN
			print @diemtbmon
			UPDATE DIEMHOCKY2
			SET DIEM = @diemtbmon
			WHERE MALOAIDIEM = 'LD0008' AND MAMONHOC = @mamonhoc AND MAHS = @mahs AND MANAMHOC = @manamhoc AND MALOP = @malop
		END
	END

--tinh diem trung binh hoc ky 1
CREATE TRIGGER T_DIEMTONGKETKY1 ON DIEMHOCKY1
FOR INSERT, UPDATE
AS
	DECLARE @diemtongket float,
			@mahs int,
			@mamonhoc varchar(10),
			@malop char(5),
			@manamhoc int,
			@diem float,
			@diemcu float,
			@diemtoithieu float,
			@diemtoida float
	SET @diemcu = 0
	SELECT @mahs = MAHS,@mamonhoc = MAMONHOC, @manamhoc = MANAMHOC, @diem = DIEM,@malop = MALOP FROM inserted WHERE MALOAIDIEM = 'LD0007'
	SELECT @diemtoithieu = DIEMTOITHIEU,@diemtoida = DIEMTOIDA FROM QUIDINH
	SELECT @diemtongket = DIEM FROM DIEMTBHOCKY WHERE MAHS = @mahs AND MALOAIDIEM = 'LD0005'
	BEGIN
		IF(@diemtongket IS NULL)
			SET @diemtongket =0
		IF((@diem<0 OR @diem>10)) BEGIN
			RAISERROR('DIEM BI LOI',16,3)
			ROLLBACK TRANSACTION
		END
		IF(EXISTS(SELECT * FROM deleted WHERE MALOAIDIEM = 'LD0007'))
			SELECT @diemcu = DIEM FROM deleted WHERE MAHS = @mahs AND MAMONHOC = @mamonhoc AND MANAMHOC = @manamhoc AND MALOAIDIEM = 'LD0007'
		SET @diemtongket = @diemtongket + @diem/9 - @diemcu/9
		IF(NOT EXISTS(SELECT * FROM DIEMTBHOCKY WHERE MAHS = @mahs AND MALOAIDIEM = 'LD0005') AND (@mahs IS NOT NULL))
			INSERT INTO DIEMTBHOCKY VALUES(@mahs, @malop,'LD0005',@diemtongket,@manamhoc,'NULL')
		ELSE BEGIN
			UPDATE DIEMTBHOCKY
			SET DIEM = @diemtongket
			WHERE MAHS = @mahs AND MANAMHOC = @manamhoc AND MALOAIDIEM = 'LD0005'
		END
	END


--tinh diem trung binh hoc ky 2
CREATE TRIGGER T_DIEMTONGKETKY2 ON DIEMHOCKY2
FOR INSERT, UPDATE
AS
	DECLARE @diemtongket float,
			@mahs int,
			@mamonhoc varchar(10),
			@malop char(5),
			@manamhoc int,
			@diem float,
			@diemcu float,
			@diemtoithieu float,
			@diemtoida float
	SET @diemcu = 0
	SELECT @mahs = MAHS,@mamonhoc = MAMONHOC, @manamhoc = MANAMHOC, @diem = DIEM,@malop = MALOP FROM inserted WHERE MALOAIDIEM = 'LD0008'
	SELECT @diemtoithieu = DIEMTOITHIEU,@diemtoida = DIEMTOIDA FROM QUIDINH
	SELECT @diemtongket = DIEM FROM DIEMTBHOCKY WHERE MAHS = @mahs AND MALOAIDIEM = 'LD0006'
	BEGIN
		print @diem
		IF(@diemtongket IS NULL)
			SET @diemtongket =0
		IF((@diem<@diemtoithieu OR @diem>@diemtoida)) BEGIN
			PRINT @diem
			RAISERROR('DIEM BI LOI',16,3)
			ROLLBACK TRANSACTION
		END
		IF(EXISTS(SELECT * FROM deleted WHERE MALOAIDIEM = 'LD0008'))
			SELECT @diemcu = DIEM FROM deleted WHERE MAHS = @mahs AND MAMONHOC = @mamonhoc AND MANAMHOC = @manamhoc AND MALOAIDIEM = 'LD0008'
		SET @diemtongket = @diemtongket + @diem/9 - @diemcu/9
		IF(NOT EXISTS(SELECT * FROM DIEMTBHOCKY WHERE MAHS = @mahs AND MALOAIDIEM = 'LD0006') AND (@mahs IS NOT NULL))
			INSERT INTO DIEMTBHOCKY VALUES(@mahs, @malop,'LD0006',@diemtongket,@manamhoc,'NULL')
		ELSE BEGIN
			UPDATE DIEMTBHOCKY
			SET DIEM = @diemtongket
			WHERE MAHS = @mahs AND MANAMHOC = @manamhoc AND MALOAIDIEM = 'LD0006'
		END
	END



--diem trung binh ca nam
	CREATE TRIGGER T_DIEMTBNAM ON DIEMTBHOCKY
	FOR INSERT, UPDATE
	AS 
		DECLARE @mahs int,
				@malop char(5),
				@maloaidiem varchar(7),
				@diem float,
				@diemcu float,
				@manamhoc int,
				@diemtbtong float,
				@diemtoida float,
				@heso int,
				@diemtoithieu float
		SELECT @diemtoida = DIEMTOIDA, @diemtoithieu = DIEMTOITHIEU FROM QUIDINH
		SELECT @mahs = MAHS, @malop = MALOP, @maloaidiem = MALOAIDIEM, @diem = DIEM, @manamhoc = MANAMHOC FROM inserted 
		SELECT @diemtbtong = DIEM FROM DIEMTBHOCKY WHER	E MAHS = @mahs AND MALOAIDIEM = 'LD0009' AND (@mahs IS NOT NULL)
		SELECT @heso = HESO FROM LOAIDIEM WHERE MALOAIDIEM = @maloaidiem
		BEGIN
			if((@mahs IS NULL) OR (@malop IS NULL) OR (@maloaidiem IS NULL))
				RETURN
			print @diem
			IF(@diem<@diemtoithieu OR @diem > @diemtoida) BEGIN
				RAISERROR('DIEM BI LOI',16,3)
				ROLLBACK TRANSACTION
			END

			IF(EXISTS (SELECT * FROM deleted))
				SELECT @diemcu = DIEM FROM deleted WHERE MAHS = @mahs AND MALOP = @malop AND MALOAIDIEM = @maloaidiem AND MANAMHOC = @manamhoc
			ELSE SET @diemcu = 0

			IF(@diemtbtong IS NULL) BEGIN
				SET @diemtbtong = @diem*@heso/3
				INSERT INTO DIEMTBHOCKY VALUES(@mahs, @malop, 'LD0009',@diemtbtong, @manamhoc, '')
			END
			ELSE BEGIN
				SET @diemtbtong += @diem*@heso/3 - @diemcu*@heso/3
				UPDATE DIEMTBHOCKY
				SET DIEM = @diemtbtong
				WHERE MALOAIDIEM = 'LD0009'
			END
				
		END


--STORE PROCDURE
--lấy thông tin học sinh theo khối
drop proc sp_ThongtinHocSinhtheoKhoi
CREATE PROC sp_ThongtinHocSinhtheoKhoi(@makhoi char(2), @magvcn char(5), @phanquyen int) 
AS
	BEGIN TRAN
		SET TRAN ISOLATION LEVEL READ COMMITTED
		IF(@phanquyen = 1) BEGIN
			SELECT HS.MAHS, HS.HOTEN, HS.NGAYSINH, HS.GIOITINH, HS.DIACHI, HS.TONGIAO, HS.EMAIL, HS.HOTENCHAC,HS.NGHENGHIEPCHA, HS.HOTENME,HS.NGHENGHIEPME, PL.MAKHOI, PL.MALOP
			FROM HOCSINH HS with (rowlock) JOIN PHANLOP PL with (rowlock) ON HS.MAHS = PL.MAHS
			WHERE PL.MAKHOI = @makhoi
		END
		ELSE BEGIN
			SELECT HS.MAHS, HS.HOTEN, HS.NGAYSINH, HS.GIOITINH, HS.DIACHI, HS.TONGIAO, HS.EMAIL, HS.HOTENCHAC,HS.NGHENGHIEPCHA, HS.HOTENME,HS.NGHENGHIEPME, PL.MAKHOI, PL.MALOP
			FROM HOCSINH HS with(rowlock) JOIN PHANLOP PL with (rowlock) ON HS.MAHS = PL.MAHS
			WHERE PL.MAKHOI = @makhoi AND EXISTS(SELECT * FROM LOP WHERE MAGVCN = @magvcn AND PL.MALOP = MALOP)
		END
	COMMIT




--lấy thông tin học sinh theo lớp
DROP PROC sp_ThongtinHocSinhtheoLop
CREATE PROC sp_ThongtinHocSinhtheoLop(@malop char(5),@magvcn char(5), @phanquyen int)
AS
	BEGIN TRAN
		SET TRAN ISOLATION LEVEL READ COMMITTED
		IF(@phanquyen = 1) BEGIN
			SELECT HS.MAHS, HS.HOTEN, HS.NGAYSINH, HS.GIOITINH, HS.DIACHI, HS.TONGIAO, HS.EMAIL, HS.HOTENCHAC,HS.NGHENGHIEPCHA, HS.HOTENME,HS.NGHENGHIEPME, PL.MAKHOI, PL.MALOP
			FROM HOCSINH HS with (xlock) JOIN PHANLOP PL with (xlock) ON HS.MAHS = PL.MAHS
			WHERE PL.MALOP = @malop
		END
		ELSE BEGIN
			SELECT HS.MAHS, HS.HOTEN, HS.NGAYSINH, HS.GIOITINH, HS.DIACHI, HS.TONGIAO, HS.EMAIL, HS.HOTENCHAC,HS.NGHENGHIEPCHA, HS.HOTENME,HS.NGHENGHIEPME, PL.MAKHOI, PL.MALOP
			FROM HOCSINH HS with(xlock) JOIN PHANLOP PL with(xlock) ON HS.MAHS = PL.MAHS
			WHERE PL.MALOP = @malop AND EXISTS(SELECT * FROM GIANGDAY WHERE MAGV = @magvcn AND PL.MALOP = MALOP)
		END
		--waitfor delay '00:00:10'
	COMMIT



--lấy thông tin điểm của học sinh theo lớp chủ nhiệm
drop proc sp_DiemHocSinhTheoLopChuNhiem
CREATE PROC sp_DiemHocSinhTheoLopChuNhiem(@malop char(5), @namhoc int, @magvcn char(5), @phanquyen int)
AS
	BEGIN TRAN
		SET TRAN ISOLATION LEVEL Serializable 
		IF(@phanquyen = 1) BEGIN
			SELECT DISTINCT HS.MAHS, HS.HOTEN,
			(SELECT DTBHK0.DIEM FROM HOCSINH HS0 JOIN DIEMTBHOCKY DTBHK0 ON HS0.MAHS = DTBHK0.MAHS WHERE DTBHK0.MALOP = @malop AND DTBHK0.MALOAIDIEM = 'LD0005' AND HS0.MAHS = HS.MAHS AND DTBHK0.MANAMHOC = @namhoc) as DIEMTBHKI,
			(SELECT DTBHK1.DIEM FROM HOCSINH HS1 JOIN DIEMTBHOCKY DTBHK1 ON HS1.MAHS = DTBHK1.MAHS WHERE DTBHK1.MALOP = @malop AND DTBHK1.MALOAIDIEM = 'LD0006' AND HS1.MAHS = HS.MAHS AND DTBHK1.MANAMHOC = @namhoc) as DIEMTBHKII,
			(SELECT DTBHK2.DIEM FROM HOCSINH HS2 JOIN DIEMTBHOCKY DTBHK2 ON HS2.MAHS = DTBHK2.MAHS WHERE DTBHK2.MALOP = @malop AND DTBHK2.MALOAIDIEM = 'LD0009' AND HS2.MAHS = HS.MAHS AND DTBHK2.MANAMHOC = @namhoc) as DIEMTBCANAM
			FROM HOCSINH HS JOIN DIEMTBHOCKY DTBHK with(rowlock) ON HS.MAHS = DTBHK.MAHS
			WHERE DTBHK.MALOP = @malop AND DTBHK.MANAMHOC = @namhoc
		END
		ELSE BEGIN
			SELECT DISTINCT HS.MAHS, HS.HOTEN,
			(SELECT DTBHK0.DIEM FROM HOCSINH HS0 JOIN DIEMTBHOCKY DTBHK0 ON HS0.MAHS = DTBHK0.MAHS WHERE DTBHK0.MALOP = @malop AND DTBHK0.MALOAIDIEM = 'LD0005' AND HS0.MAHS = HS.MAHS AND DTBHK0.MANAMHOC = @namhoc AND EXISTS(SELECT* FROM LOP WHERE MAGVCN = @magvcn AND DTBHK.MALOP = MALOP)) as DIEMTBHKI,
			(SELECT DTBHK1.DIEM FROM HOCSINH HS1 JOIN DIEMTBHOCKY DTBHK1 ON HS1.MAHS = DTBHK1.MAHS WHERE DTBHK1.MALOP = @malop AND DTBHK1.MALOAIDIEM = 'LD0006' AND HS1.MAHS = HS.MAHS AND DTBHK1.MANAMHOC = @namhoc AND EXISTS(SELECT* FROM LOP WHERE MAGVCN = @magvcn AND DTBHK.MALOP = MALOP)) as DIEMTBHKII,
			(SELECT DTBHK2.DIEM FROM HOCSINH HS2 JOIN DIEMTBHOCKY DTBHK2 ON HS2.MAHS = DTBHK2.MAHS WHERE DTBHK2.MALOP = @malop AND DTBHK2.MALOAIDIEM = 'LD0009' AND HS2.MAHS = HS.MAHS AND DTBHK2.MANAMHOC = @namhoc AND EXISTS(SELECT* FROM LOP WHERE MAGVCN = @magvcn AND DTBHK.MALOP = MALOP)) as DIEMTBCANAM
			FROM HOCSINH HS JOIN DIEMTBHOCKY DTBHK with(rowlock) ON HS.MAHS = DTBHK.MAHS
			WHERE DTBHK.MALOP = @malop AND DTBHK.MANAMHOC = @namhoc AND EXISTS(SELECT* FROM LOP WHERE MAGVCN = @magvcn AND DTBHK.MALOP = MALOP)
		END
	COMMIT


--lấy thông tin điểm cụ thể của học sinh
DROP PROC sp_DiemHocSinh
CREATE PROC sp_DiemHocSinh(@mahs int, @namhoc int, @hocky char(2))
AS
	BEGIN TRAN
			SET TRAN ISOLATION LEVEL Serializable 
			IF(@hocky = 1)BEGIN
				SELECT DISTINCT TENMONHOC,
				(SELECT D1.DIEM FROM DIEMHOCKY1 D1 JOIN MONHOC MH1 ON D1.MAMONHOC = MH1.MAMONHOC WHERE D1.MANAMHOC = @namhoc AND D1.MALOAIDIEM = 'LD0001' AND MH.MAMONHOC = MH1.MAMONHOC AND D1.MAHS = @mahs) AS DIEMMIENG,
				(SELECT D2.DIEM FROM DIEMHOCKY1 D2 JOIN MONHOC MH2 ON D2.MAMONHOC = MH2.MAMONHOC WHERE D2.MANAMHOC = @namhoc AND D2.MALOAIDIEM = 'LD0002' AND MH.MAMONHOC = MH2.MAMONHOC AND D2.MAHS = @mahs) AS DIEM15P,
				(SELECT D3.DIEM FROM DIEMHOCKY1 D3 JOIN MONHOC MH3 ON D3.MAMONHOC = MH3.MAMONHOC WHERE D3.MANAMHOC = @namhoc AND D3.MALOAIDIEM = 'LD0003' AND MH.MAMONHOC = MH3.MAMONHOC AND D3.MAHS = @mahs) AS DIEM1TIET,
				(SELECT D4.DIEM FROM DIEMHOCKY1 D4 JOIN MONHOC MH4 ON D4.MAMONHOC = MH4.MAMONHOC WHERE D4.MANAMHOC = @namhoc AND D4.MALOAIDIEM = 'LD0004' AND MH.MAMONHOC = MH4.MAMONHOC AND D4.MAHS = @mahs) AS DIEMTHI,
				(SELECT D5.DIEM FROM DIEMHOCKY1 D5 JOIN MONHOC MH5 ON D5.MAMONHOC = MH5.MAMONHOC WHERE D5.MANAMHOC = @namhoc AND D5.MALOAIDIEM = 'LD0007' AND MH.MAMONHOC = MH5.MAMONHOC AND D5.MAHS = @mahs) AS DIEMTBMON
				FROM MONHOC MH JOIN DIEMHOCKY1 D WITH(ROWLOCK) ON MH.MAMONHOC = D.MAMONHOC
				WHERE D.MANAMHOC = @namhoc AND D.MAHS = @mahs
			END
			ELSE BEGIN
				SELECT DISTINCT TENMONHOC,
				(SELECT D1.DIEM FROM DIEMHOCKY2 D1 JOIN MONHOC MH1 ON D1.MAMONHOC = MH1.MAMONHOC WHERE D1.MANAMHOC = @namhoc AND D1.MALOAIDIEM = 'LD0001' AND MH.MAMONHOC = MH1.MAMONHOC AND D1.MAHS = @mahs) AS DIEMMIENG,
				(SELECT D2.DIEM FROM DIEMHOCKY2 D2 JOIN MONHOC MH2 ON D2.MAMONHOC = MH2.MAMONHOC WHERE D2.MANAMHOC = @namhoc AND D2.MALOAIDIEM = 'LD0002' AND MH.MAMONHOC = MH2.MAMONHOC AND D2.MAHS = @mahs) AS DIEM15P,
				(SELECT D3.DIEM FROM DIEMHOCKY2 D3 JOIN MONHOC MH3 ON D3.MAMONHOC = MH3.MAMONHOC WHERE D3.MANAMHOC = @namhoc AND D3.MALOAIDIEM = 'LD0003' AND MH.MAMONHOC = MH3.MAMONHOC AND D3.MAHS = @mahs) AS DIEM1TIET,
				(SELECT D4.DIEM FROM DIEMHOCKY2 D4 JOIN MONHOC MH4 ON D4.MAMONHOC = MH4.MAMONHOC WHERE D4.MANAMHOC = @namhoc AND D4.MALOAIDIEM = 'LD0004' AND MH.MAMONHOC = MH4.MAMONHOC AND D4.MAHS = @mahs) AS DIEMTHI,
				(SELECT D5.DIEM FROM DIEMHOCKY2 D5 JOIN MONHOC MH5 ON D5.MAMONHOC = MH5.MAMONHOC WHERE D5.MANAMHOC = @namhoc AND D5.MALOAIDIEM = 'LD0008' AND MH.MAMONHOC = MH5.MAMONHOC AND D5.MAHS = @mahs) AS DIEMTBMON
				FROM MONHOC MH JOIN DIEMHOCKY2 D WITH (ROWLOCK) ON MH.MAMONHOC = D.MAMONHOC
				WHERE D.MANAMHOC = @namhoc AND D.MAHS = @mahs
			END
	COMMIT

--lấy thông tin điểm của học sinh theo khối (code mới)
drop proc sp_DiemHocSinhTheoKhoi
CREATE PROC sp_DiemHocSinhTheoKhoi(@makhoi char(5), @namhoc int, @magvcn char(5), @phanquyen int)
AS
	BEGIN TRAN
		SET TRAN ISOLATION LEVEL Serializable 
		IF(@phanquyen = 1) BEGIN
			SELECT DISTINCT HS.MAHS, HS.HOTEN,
			(SELECT DTBHK0.DIEM FROM HOCSINH HS0 JOIN DIEMTBHOCKY DTBHK0 ON HS0.MAHS = DTBHK0.MAHS WHERE DTBHK0.MALOAIDIEM = 'LD0005' AND HS0.MAHS = HS.MAHS AND DTBHK0.MANAMHOC = @namhoc) as DIEMTBHKI,
			(SELECT DTBHK1.DIEM FROM HOCSINH HS1 JOIN DIEMTBHOCKY DTBHK1 ON HS1.MAHS = DTBHK1.MAHS WHERE DTBHK1.MALOAIDIEM = 'LD0006' AND HS1.MAHS = HS.MAHS AND DTBHK1.MANAMHOC = @namhoc) as DIEMTBHKII,
			(SELECT DTBHK2.DIEM FROM HOCSINH HS2 JOIN DIEMTBHOCKY DTBHK2 ON HS2.MAHS = DTBHK2.MAHS WHERE DTBHK2.MALOAIDIEM = 'LD0009' AND HS2.MAHS = HS.MAHS AND DTBHK2.MANAMHOC = @namhoc) as DIEMTBCANAM
			FROM (HOCSINH HS JOIN DIEMTBHOCKY DTBHK with(rowlock) ON HS.MAHS = DTBHK.MAHS) JOIN PHANLOP PL ON DTBHK.MALOP = PL.MALOP
			WHERE PL.MAKHOI = @makhoi AND DTBHK.MANAMHOC = @namhoc
		END
		ELSE BEGIN
			SELECT DISTINCT HS.MAHS, HS.HOTEN,
			(SELECT DTBHK0.DIEM FROM HOCSINH HS0 JOIN DIEMTBHOCKY DTBHK0 ON HS0.MAHS = DTBHK0.MAHS WHERE DTBHK0.MALOAIDIEM = 'LD0005' AND HS0.MAHS = HS.MAHS AND DTBHK0.MANAMHOC = @namhoc AND EXISTS(SELECT* FROM LOP WHERE MAGVCN = @magvcn AND DTBHK.MALOP = MALOP)) as DIEMTBHKI,
			(SELECT DTBHK1.DIEM FROM HOCSINH HS1 JOIN DIEMTBHOCKY DTBHK1 ON HS1.MAHS = DTBHK1.MAHS WHERE DTBHK1.MALOAIDIEM = 'LD0006' AND HS1.MAHS = HS.MAHS AND DTBHK1.MANAMHOC = @namhoc AND EXISTS(SELECT* FROM LOP WHERE MAGVCN = @magvcn AND DTBHK.MALOP = MALOP)) as DIEMTBHKII,
			(SELECT DTBHK2.DIEM FROM HOCSINH HS2 JOIN DIEMTBHOCKY DTBHK2 ON HS2.MAHS = DTBHK2.MAHS WHERE DTBHK2.MALOAIDIEM = 'LD0009' AND HS2.MAHS = HS.MAHS AND DTBHK2.MANAMHOC = @namhoc AND EXISTS(SELECT* FROM LOP WHERE MAGVCN = @magvcn AND DTBHK.MALOP = MALOP)) as DIEMTBCANAM
			FROM (HOCSINH HS JOIN DIEMTBHOCKY DTBHK with(rowlock) ON HS.MAHS = DTBHK.MAHS) JOIN PHANLOP PL ON DTBHK.MALOP = PL.MALOP
			WHERE PL.MAKHOI = @makhoi AND DTBHK.MANAMHOC = @namhoc AND EXISTS(SELECT* FROM LOP  L WHERE L.MAGVCN = @magvcn AND PL.MALOP = MALOP)
		END
	COMMIT

--lấy thông tin điểm của học sinh theo khối(lớp bộ môn) (code mới)
DROP PROC sp_DiemHocSinhTheoKhoi_LopBoMon
CREATE PROC sp_DiemHocSinhTheoKhoi_LopBoMon(@makhoi char(5), @mamon varchar(10), @namhoc int, @magv char(5), @phanquyen int)
AS
	BEGIN TRAN
		SET TRAN ISOLATION LEVEL Serializable
		IF(@phanquyen = 1)BEGIN
			SELECT HS.MAHS, HS.HOTEN,
			(SELECT D1.DIEM FROM DIEMHOCKY1 D1 WITH(ROWLOCK) WHERE MALOAIDIEM = 'LD0007' AND MAMONHOC = @mamon AND MANAMHOC = @namhoc AND D1.MAHS = HS.MAHS) AS DIEMTBMONHKI,
			(SELECT D2.DIEM FROM DIEMHOCKY2 D2 WITH(ROWLOCK) WHERE MALOAIDIEM = 'LD0008' AND MAMONHOC = @mamon AND MANAMHOC = @namhoc AND D2.MAHS = HS.MAHS) AS DIEMTBMONHKII
			FROM (HOCSINH HS JOIN PHANLOP PL ON HS.MAHS = PL.MAHS) JOIN GIANGDAY GD ON PL.MALOP = GD.MALOP
			WHERE GD.MAMONHOC = @mamon AND PL.MAKHOI = @makhoi AND GD.MANAMHOC = @namhoc
		END
		ELSE BEGIN
			SELECT HS.MAHS, HS.HOTEN,
			(SELECT D1.DIEM FROM DIEMHOCKY1 D1 WITH(ROWLOCK) WHERE MALOAIDIEM = 'LD0007' AND MAMONHOC = @mamon AND MANAMHOC = @namhoc AND D1.MAHS = HS.MAHS) AS DIEMTBMONHKI,
			(SELECT D2.DIEM FROM DIEMHOCKY2 D2 WITH(ROWLOCK) WHERE MALOAIDIEM = 'LD0008' AND MAMONHOC = @mamon AND MANAMHOC = @namhoc AND D2.MAHS = HS.MAHS) AS DIEMTBMONHKII
			FROM (HOCSINH HS JOIN PHANLOP PL ON HS.MAHS = PL.MAHS) JOIN GIANGDAY GD ON PL.MALOP = GD.MALOP
			WHERE GD.MAGV = @magv AND GD.MAMONHOC = @mamon AND PL.MAKHOI = @makhoi AND GD.MANAMHOC = @namhoc
		END
	COMMIT

--lấy thông tin điểm của học sinh theo lớp bộ môn
DROP PROC sp_DiemHocSinhTheoLopBoMon
CREATE PROC sp_DiemHocSinhTheoLopBoMon(@malop char(5), @mamon varchar(10), @namhoc int, @magv char(5), @phanquyen int)
AS
	BEGIN TRAN
		SET TRAN ISOLATION LEVEL Serializable
		IF(@phanquyen = 1)BEGIN
			SELECT HS.MAHS, HS.HOTEN,
			(SELECT D1.DIEM FROM DIEMHOCKY1 D1 WITH(xLOCK) WHERE MALOAIDIEM = 'LD0007' AND MAMONHOC = @mamon AND MALOP = @malop AND MANAMHOC = @namhoc AND D1.MAHS = HS.MAHS) AS DIEMTBMONHKI,
			(SELECT D2.DIEM FROM DIEMHOCKY2 D2 WITH(xLOCK) WHERE MALOAIDIEM = 'LD0008' AND MAMONHOC = @mamon AND MALOP = @malop AND MANAMHOC = @namhoc AND D2.MAHS = HS.MAHS) AS DIEMTBMONHKII
			FROM (HOCSINH HS JOIN PHANLOP PL ON HS.MAHS = PL.MAHS) JOIN GIANGDAY GD ON PL.MALOP = GD.MALOP
			WHERE GD.MAMONHOC = @mamon AND GD.MALOP = @malop AND GD.MANAMHOC = @namhoc
		END
		ELSE BEGIN
			SELECT HS.MAHS, HS.HOTEN,
			(SELECT D1.DIEM FROM DIEMHOCKY1 D1 WITH(xLOCK) WHERE MALOAIDIEM = 'LD0007' AND MAMONHOC = @mamon AND MALOP = @malop AND MANAMHOC = @namhoc AND D1.MAHS = HS.MAHS) AS DIEMTBMONHKI,
			(SELECT D2.DIEM FROM DIEMHOCKY2 D2 WITH(xLOCK) WHERE MALOAIDIEM = 'LD0008' AND MAMONHOC = @mamon AND MALOP = @malop AND MANAMHOC = @namhoc AND D2.MAHS = HS.MAHS) AS DIEMTBMONHKII
			FROM (HOCSINH HS JOIN PHANLOP PL ON HS.MAHS = PL.MAHS) JOIN GIANGDAY GD ON PL.MALOP = GD.MALOP
			WHERE GD.MAGV = @magv AND GD.MAMONHOC = @mamon AND GD.MALOP = @malop AND GD.MANAMHOC = @namhoc
		END
		--waitfor delay '00:00:10'
	COMMIT


--diem 1 hoc sinh theo mon
DROP PROC sp_Diem1HocSinhTheoBoMon
CREATE PROC sp_Diem1HocSinhTheoBoMon(@mahs int, @mamon varchar(10), @namhoc int, @magv char(5), @phanquyen int)
AS 
	BEGIN TRAN
		SET TRAN ISOLATION LEVEL Serializable
		IF(@phanquyen = 1)BEGIN
			SELECT
			(SELECT D1.DIEM FROM DIEMHOCKY1 D1 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0001' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D1.MAHS = @mahs) AS D_MIENGHKI,
			(SELECT D1.DIEM FROM DIEMHOCKY1 D1 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0002' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D1.MAHS = @mahs) AS D_15PHKI,
			(SELECT D1.DIEM FROM DIEMHOCKY1 D1 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0003' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D1.MAHS = @mahs) AS D_1TIETHKI,
			(SELECT D1.DIEM FROM DIEMHOCKY1 D1 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0004' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D1.MAHS = @mahs) AS D_THIHKI,
			(SELECT D1.DIEM FROM DIEMHOCKY1 D1 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0007' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D1.MAHS = @mahs) AS D_TBMONHKI,
			(SELECT D2.DIEM FROM DIEMHOCKY2 D2 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0001' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D2.MAHS = @mahs) AS D_MIENGHKII,
			(SELECT D2.DIEM FROM DIEMHOCKY2 D2 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0002' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D2.MAHS = @mahs) AS D_15PHKII,
			(SELECT D2.DIEM FROM DIEMHOCKY2 D2 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0003' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D2.MAHS = @mahs) AS D_1TIETHKII,
			(SELECT D2.DIEM FROM DIEMHOCKY2 D2 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0004' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D2.MAHS = @mahs) AS D_THIHKII,
			(SELECT D2.DIEM FROM DIEMHOCKY2 D2 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0008' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D2.MAHS = @mahs) AS D_TBMONHKII
			FROM (HOCSINH HS JOIN PHANLOP PL ON HS.MAHS = PL.MAHS) JOIN GIANGDAY GD ON PL.MALOP = GD.MALOP
			WHERE GD.MAMONHOC = @mamon AND GD.MANAMHOC = @namhoc AND HS.MAHS = @mahs
		END
		ELSE BEGIN
			SELECT
			(SELECT D1.DIEM FROM DIEMHOCKY1 D1 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0001' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D1.MAHS = @mahs) AS D_MIENGHKI,
			(SELECT D1.DIEM FROM DIEMHOCKY1 D1 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0002' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D1.MAHS = @mahs) AS D_15PHKI,
			(SELECT D1.DIEM FROM DIEMHOCKY1 D1 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0003' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D1.MAHS = @mahs) AS D_1TIETHKI,
			(SELECT D1.DIEM FROM DIEMHOCKY1 D1 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0004' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D1.MAHS = @mahs) AS D_THIHKI,
			(SELECT D1.DIEM FROM DIEMHOCKY1 D1 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0007' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D1.MAHS = @mahs) AS D_TBMONHKI,
			(SELECT D2.DIEM FROM DIEMHOCKY2 D2 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0001' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D2.MAHS = @mahs) AS D_MIENGHKII,
			(SELECT D2.DIEM FROM DIEMHOCKY2 D2 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0002' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D2.MAHS = @mahs) AS D_15PHKII,
			(SELECT D2.DIEM FROM DIEMHOCKY2 D2 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0003' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D2.MAHS = @mahs) AS D_1TIETHKII,
			(SELECT D2.DIEM FROM DIEMHOCKY2 D2 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0004' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D2.MAHS = @mahs) AS D_THIHKII,
			(SELECT D2.DIEM FROM DIEMHOCKY2 D2 WITH (ROWLOCK) WHERE MALOAIDIEM = 'LD0008' AND MAMONHOC = @mamon AND MANAMHOC = 2014 AND D2.MAHS = @mahs) AS D_TBMONHKII
			FROM (HOCSINH HS JOIN PHANLOP PL ON HS.MAHS = PL.MAHS) JOIN GIANGDAY GD ON PL.MALOP = GD.MALOP
			WHERE GD.MAGV = @magv AND GD.MAMONHOC = @mamon AND GD.MANAMHOC = @namhoc AND HS.MAHS = @mahs
		END
	COMMIT


--sửa điểm học sinh
exec sp_SuaDiem 1,'10a1','mh0001',2014,1,1,1,1,1,1,1,1
DROP PROC sp_SuaDiem
CREATE PROC sp_SuaDiem(
	@mahs int, 
	@malop char(5),
	@mamon varchar(10), 
	@namhoc int,
	@d_mieng_hkI float, @d_15p_hkI float, @d_1tiet_hkI float, @d_thi_hkI float,
	@d_mieng_hkII float, @d_15p_hkII float, @d_1tiet_hkII float, @d_thi_hkII float
	) 
AS 
	BEGIN  TRAN
		SELECT * FROM DIEMHOCKY1 with(xlock) WHERE MAHS = @mahs AND MALOP = @malop AND MAMONHOC = @mamon AND MANAMHOC = @namhoc
		IF(@@ROWCOUNT=0)
			ROLLBACK TRANSACTION
		
		UPDATE DIEMHOCKY1 with(xlock)
		SET DIEM = @d_mieng_hkI
		WHERE MAHS = @mahs AND MALOP = @malop AND MAMONHOC = @mamon AND MANAMHOC = @namhoc AND MALOAIDIEM = 'LD0001'
		IF(@@ERROR<>0)
			ROLLBACK TRANSACTION

		UPDATE DIEMHOCKY1 with(xlock)
		SET DIEM = @d_15p_hkI
		WHERE MAHS = @mahs AND MALOP = @malop AND MAMONHOC = @mamon AND MANAMHOC = @namhoc AND MALOAIDIEM = 'LD0002'
		IF(@@ERROR<>0)
			ROLLBACK TRANSACTION
		
		UPDATE DIEMHOCKY1 with(xlock)
		SET DIEM = @d_1tiet_hkI
		WHERE MAHS = @mahs AND MALOP = @malop AND MAMONHOC = @mamon AND MANAMHOC = @namhoc AND MALOAIDIEM = 'LD0003'
		IF(@@ERROR<>0)
			ROLLBACK TRANSACTION

		UPDATE DIEMHOCKY1 with(xlock)
		SET DIEM = @d_thi_hkI
		WHERE MAHS = @mahs AND MALOP = @malop AND MAMONHOC = @mamon AND MANAMHOC = @namhoc AND MALOAIDIEM = 'LD0004'
		IF(@@ERROR<>0)
			ROLLBACK TRANSACTION
		
		UPDATE DIEMHOCKY2 with(xlock)
		SET DIEM = @d_mieng_hkII
		WHERE MAHS = @mahs AND MALOP = @malop AND MAMONHOC = @mamon AND MANAMHOC = @namhoc AND MALOAIDIEM = 'LD0001'
		IF(@@ERROR<>0)
			ROLLBACK TRANSACTION
		
		UPDATE DIEMHOCKY2 with(xlock)
		SET DIEM = @d_15p_hkII
		WHERE MAHS = @mahs AND MALOP = @malop AND MAMONHOC = @mamon AND MANAMHOC = @namhoc AND MALOAIDIEM = 'LD0002'
		IF(@@ERROR<>0)
			ROLLBACK TRANSACTION
		
		UPDATE DIEMHOCKY2 with(xlock)
		SET DIEM = @d_1tiet_hkII
		WHERE MAHS = @mahs AND MALOP = @malop AND MAMONHOC = @mamon AND MANAMHOC = @namhoc AND MALOAIDIEM = 'LD0003'
		IF(@@ERROR<>0)
			ROLLBACK TRANSACTION
		
		UPDATE DIEMHOCKY2 with(xlock)
		SET DIEM = @d_thi_hkII
		WHERE MAHS = @mahs AND MALOP = @malop AND MAMONHOC = @mamon AND MANAMHOC = @namhoc AND MALOAIDIEM = 'LD0004'
		IF(@@ERROR<>0)
			ROLLBACK TRANSACTION
		--waitfor delay '00:00:10'
	COMMIT

	
--xoá một học sinh
CREATE PROC sp_XoathongtinHocSinh(@mahs int)
AS
	BEGIN
		IF(NOT EXISTS (SELECT * FROM HOCSINH WHERE MAHS = @mahs))
			PRINT N'Học sinh không tồn tại'
		ELSE
			BEGIN TRAN
				SET TRAN ISOLATION LEVEL READ COMMITTED
				DELETE FROM PHANLOP WHERE MAHS = @mahs
				IF(@@ERROR<>0)
					ROLLBACK TRANSACTION
				DELETE FROM DIEM WHERE MAHS = @mahs
				IF(@@ERROR<>0)
					ROLLBACK TRANSACTION
				DELETE FROM HOCSINH WHERE MAHS = @mahs
				IF(@@ERROR<>0)
					ROLLBACK TRANSACTION
			COMMIT
	END

--sửa thông tin học sinh
exec sp_demo
drop proc sp_demo
create proc sp_demo
as
	begin tran
		select * from hocsinh --with (xlock)
	commit

drop proc sp_SuaThongtinHocSinh
exec sp_SuaThongtinHocSinh 2,'bbb','','','','','','','','','','10A1',''
CREATE PROC sp_SuaThongtinHocSinh(
	@mahs int, 
	@hoten nvarchar(50), 
	@gioitinh char(3), 
	@ngaysinh smalldatetime, 
	@diachi nvarchar(200),
	@email varchar(30),
	@tongiao varchar(30),
	@hotencha varchar(30),
	@nghenghiepcha varchar(30),
	@hotenme varchar(30),
	@nghenghiepme varchar(30),
	@malop char(5),
	@image varchar(200)
	) 
AS 
	BEGIN
		IF(NOT EXISTS (SELECT * FROM HOCSINH with (xlock) WHERE MAHS = @mahs))
			PRINT N'Học sinh không tồn tại'
		ELSE
		BEGIN TRAN
			UPDATE HOCSINH with (xlock)
			SET HOTEN = @hoten, GIOITINH = @gioitinh, NGAYSINH = @ngaysinh, DIACHI = @diachi, EMAIL = @email, TONGIAO = @tongiao, HOTENCHAC = @hotencha,
				HOTENME = @hotenme, NGHENGHIEPME = @nghenghiepme, NGHENGHIEPCHA = @nghenghiepcha, IMAGEE = @image
			WHERE MAHS = @mahs
			IF(@@ERROR<>0)
				ROLLBACK TRANSACTION
			UPDATE PHANLOP with (xlock)
			SET MALOP = @malop
			WHERE MAHS = @mahs	
				IF(@@ERROR<>0)
				ROLLBACK TRANSACTION
			--waitfor delay '00:00:10'
		commit
	END


--thêm học sinh
drop proc sp_ThemHocSinh

select * from HOCSINH
exec sp_ThemHocSinh 1,'vdfvbdf','','1/1/2001','','','','','','','','10a1',2014,'10',''
INSERT INTO PHANLOP VALUES(1,'10a1', 2014, '10','')	

CREATE PROC sp_ThemHocSinh(
	@mahs int, 
	@hoten nvarchar(50), 
	@gioitinh char(3), 
	@ngaysinh smalldatetime, 
	@diachi nvarchar(200),
	@email varchar(30),
	@tongiao varchar(30),
	@hotencha varchar(30),
	@nghenghiepcha varchar(30),
	@hotenme varchar(30),
	@nghenghiepme varchar(30),
	@malop char(5),
	@manamhoc int,
	@makhoilop char(2),
	@image varchar(200)
	)
AS
	DECLARE @mamonhoc varchar(10)
	BEGIN
		IF(EXISTS (SELECT * FROM HOCSINH WHERE MAHS = @mahs))
			RETURN 1
		ELSE

		BEGIN TRAN
			SET TRAN ISOLATION LEVEL READ COMMITTED
			INSERT INTO HOCSINH VALUES(@mahs,@hoten,@gioitinh,@ngaysinh,@diachi,@email,@tongiao,@hotencha,@hotenme,@nghenghiepme,@nghenghiepcha, @image)
			IF(@@ERROR<>0)
				ROLLBACK TRANSACTION
				
			INSERT INTO PHANLOP VALUES(@mahs,@malop, @manamhoc, @makhoilop,'')	
			IF(@@ERROR<>0)
				ROLLBACK TRANSACTION
			
			declare c cursor scroll for select mamonhoc from MONHOC
			open c
			fetch next from c into @mamonhoc
			while(@@FETCH_STATUS=0)	begin
				insert into DIEMHOCKY1 values(@mahs,@mamonhoc, @manamhoc, @malop,'ld0001',0,'');
				IF(@@ERROR<>0)
					ROLLBACK TRANSACTION
					
				insert into DIEMHOCKY1 values(@mahs,@mamonhoc, @manamhoc, @malop,'ld0002',0,'');
				IF(@@ERROR<>0)
					ROLLBACK TRANSACTION
				insert into DIEMHOCKY1 values(@mahs,@mamonhoc, @manamhoc, @malop,'ld0003',0,'');
				IF(@@ERROR<>0)
					ROLLBACK TRANSACTION
				insert into DIEMHOCKY1 values(@mahs,@mamonhoc, @manamhoc, @malop,'ld0004',0,'');
				IF(@@ERROR<>0)
					ROLLBACK TRANSACTION
					
				insert into DIEMHOCKY2 values(@mahs,@mamonhoc, @manamhoc, @malop,'ld0001',0,'');
				IF(@@ERROR<>0)
					ROLLBACK TRANSACTION
				insert into DIEMHOCKY2 values(@mahs,@mamonhoc, @manamhoc, @malop,'ld0002',0,'');
				IF(@@ERROR<>0)
					ROLLBACK TRANSACTION
				insert into DIEMHOCKY2 values(@mahs,@mamonhoc, @manamhoc, @malop,'ld0003',0,'');
				IF(@@ERROR<>0)
					ROLLBACK TRANSACTION
				insert into DIEMHOCKY2 values(@mahs,@mamonhoc, @manamhoc, @malop,'ld0004',0,'');
				IF(@@ERROR<>0)
					ROLLBACK TRANSACTION
					
				fetch next from c into @mamonhoc
				if(@@FETCH_STATUS<>0)
					break	
			end
			close c
		
		COMMIT
	END

	SELECT * FROM DIEMHOCKY1
--tìm kiếm thông tin học sinh
CREATE PROC sp_TiemKiemHocSinh(@hoten nvarchar(50))
AS
	BEGIN
		SELECT HS.MAHS, HS.HOTEN, HS.NGAYSINH, HS.GIOITINH, HS.DIACHI, HS.TONGIAO, HS.EMAIL, HS.HOTENCHAC,HS.NGHENGHIEPCHA, HS.HOTENME,HS.NGHENGHIEPME, PL.MAKHOILOP, PL.MALOP
	    FROM HOCSINH HS JOIN PHANLOP PL ON HS.MAHS = PL.MAHS
		WHERE HS.HOTEN LIKE '%'+@hoten+'%'
	END


--phân quyền, đăng nhập
select * from giaovien
drop proc sp_DangNhap
CREATE PROC sp_DangNhap(@username char(5), @password varchar(30),@check int output, @name nvarchar(20) output,@malop char(5) output, @phanquyen int output)
AS
	SET @check =0
	BEGIN
		IF(EXISTS (SELECT * FROM USERS WHERE ID = @username AND PASSWORD = @password)) BEGIN TRAN
			SET @check = 2
			SELECT @name = HOTEN FROM GIAOVIEN WHERE MAGV = @username
			SELECT @phanquyen = PHANQUYEN FROM USERS WHERE ID = @username
			SAVE TRAN B
			SELECT @malop = MALOP FROM LOP WHERE MAGVCN = @username
			IF(@@ERROR<>0 OR @@ROWCOUNT = 0) BEGIN
				ROLLBACK TRAN B
			END
			ELSE SET @check = 1
		COMMIT
	END


--lay ma lop bo mon cua giao vien
CREATE PROC sp_LayGVBoMon(@magv char(5))
AS
	BEGIN
		SELECT MALOP FROM MONHOC MH JOIN GIANGDAY GD ON MH.MAMONHOC = GD.MAMONHOC WHERE GD.MAGV = @magv
	END

	DROP PROC sp_LayGVBoMon

-- lay dia chi hinh anh cua hoc sinh tren mayss
create proc sp_LayImageHS(@mahs int , @image varchar(200) out)
as
	begin
		select @image = IMAGEE from HOCSINH where MAHS = @mahs
	end

select imagee from HOCSINH where mahs = 2

delete from DIEMHOCKY1
delete from DIEMHOCKY2
delete from DIEMTBHOCKY

exec sp_demo1  'bbb'
drop proc sp_demo1
create proc sp_demo1(@hoten nvarchar(50))
as
	begin tran
		update hocsinh
		set hoten = @hoten
		where mahs = 3
		waitfor delay'00:00:10'
	rollback tran

	select * from hocsinh


drop proc sp_demo
 
create proc sp_demo
as
	begin tran
		set tran isolation level read committed
		select * from hocsinh with (rowlock) where mahs = 3
	commit

exec sp_InsertDuLieuGV 'gv005','','1/1/2000','','','','',1,1
drop proc sp_InsertDuLieuGV
select * from giaovien
select * from users
delete from users where id = 'gv005'
create proc sp_InsertDuLieuGV(@magv char(5),@hoten nvarchar(20),@ngaysinh smalldatetime, @gioitinh char(3), @sodt varchar(11),@pass varchar(30), @email varchar(4),@phanquyen int,@type int)
as
	begin tran
		if ((exists (select * from giaovien where magv= @magv))) begin
			if (exists (select * from users where id = @magv)) begin
				update users
				set password = @pass, email = @email, phanquyen = @phanquyen
				where id = @magv
				if(@@ERROR<>0)
					rollback tran
				end
			end
		else begin
				insert into giaovien values(@magv,@hoten,@ngaysinh, @gioitinh,@sodt)
				if(@@ERROR<>0)
					rollback tran
				insert into users values(@magv,@pass,@email,@phanquyen)
				if(@@ERROR<>0)
					rollback tran
		end
	commit

drop proc sp_LoadDuLieuGV
create proc sp_LoadDuLieuGV
as
	begin
		select magv, hoten, ngaysinh, gioitinh, sodt,email, password, phanquyen from giaovien, users where magv = id
	end

	drop proc sp_UpdateDuLieuGV
	exec sp_UpdateDuLieuGV 'gv002','','1/1/2000','','','','',1
create proc sp_UpdateDuLieuGV(@magv char(5),@hoten nvarchar(20),@ngaysinh smalldatetime, @gioitinh char(3), @sodt varchar(11),@pass varchar(30), @email varchar(4),@phanquyen int)
as
	begin tran
		if not exists (select * from giaovien where magv = @magv)
			return

			update giaovien
			set hoten = @hoten, ngaysinh = @ngaysinh, gioitinh = @gioitinh, sodt = @sodt
			where magv = @magv
			if(@@ERROR<>0)
				rollback tran
			
			if(not exists (select * from users where id = @magv and password ='123456')) begin
				update users
				set PASSWORD = @pass, EMAIL = @email, PHANQUYEN = @phanquyen
				where ID = @magv
				if(@@ERROR<>0)
					rollback tran
			end
	commit

create proc sp_LayHocSinh(@mahs int)
as
	begin
		select * from hocsinh
	end



	--backup database
drop proc sp_BackupData
create proc sp_BackupData(@path varchar(100))
as
	begin
		backup database sql_quanlyhocsinh
		to disk = @path
	end

	--restore database
	drop proc sp_Restore

	USE master
	exec sp_Restore 'e:/quanlyhocsinh.bak'

create proc sp_Restore(@path varchar(100))
as
	begin
		restore database SQL_QUANLYHOCSINH
		from disk = @path
		with replace
	end


exec demorestore
create proc demorestore
as
	begin
	print 'demo restore'
	end

	drop proc sp_getMahsMax
create proc sp_getMahsMax(@mahs int out)
as
	begin tran
		select top(1) @mahs = mahs from hocsinh with (xlock) order by mahs desc
	commit

	declare @demo int
	exec sp_getMahsMax @demo out
	print @demo
