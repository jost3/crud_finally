--MOSTRAR DATOS--

CREATE PROC  SP_mostrar
AS
SELECT * FROM estudiante23
GO

--INSERTAR DATOS

CREATE PROC SP_insertar
@ID INT,
@nombre NVARCHAR(35),
@apellido NVARCHAR(50),
@sexo NVARCHAR(15),
@dni INT
AS
INSERT INTO estudiante23 VALUES(@ID,@nombre,@apellido,@sexo,@dni)
GO

--ACTUALIZAR DATOS--

CREATE PROC SP_modificar
@ID INT,
@nombre NVARCHAR(35),
@apellido NVARCHAR(50),
@sexo NVARCHAR(15),
@dni INT
AS
UPDATE estudiante23 SET nombre = @nombre, apellido = @apellido, sexo = @sexo, dni = @dni
WHERE ID = @ID
GO

-- ELIMINAR DATOS--

CREATE PROC SP_eliminar
@ID INT
AS
DELETE estudiante23 WHERE ID = @ID
GO

--BUSCAR DATOS--

CREATE PROC SP_buscar
@buscar NVARCHAR(35)
AS
SELECT * FROM estudiante23
WHERE nombre LIKE + @buscar + '%'
GO