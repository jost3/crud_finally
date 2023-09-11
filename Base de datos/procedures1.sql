--VER DATOS--
CREATE PROC sp_mostrar1
AS
SELECT * FROM estudiantes1

--INSERTAR DATOS--
CREATE PROC mostrar1
@ID INT,
@nombre NVARCHAR(35),
@apellido NVARCHAR(50),
@sexo NVARCHAR(15),
@dni INT
AS
INSERT INTO estudiantes VALUES (@ID, @nombre,@apellido,@sexo,@dni)
GO