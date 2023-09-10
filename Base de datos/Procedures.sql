--ver datos--
CREATE PROC sp_mostrar
AS
SELECT * FROM estudiantes
GO
--Insertar datos--
CREATE PROC insertar
@ID INT,
@nombre NVARCHAR(35),
@apellido NVARCHAR(50),
@sexo NVARCHAR(15),
@dni CHAR(8)
AS

INSERT INTO estudiantes VALUES (@ID, @nombre,@apellido,@sexo,@dni)
GO