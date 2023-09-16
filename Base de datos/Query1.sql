CREATE TABLE estudiante23(
ID INT PRIMARY KEY,
nombre NVARCHAR(35),
apellido NVARCHAR(50),
sexo NVARCHAR(15),
dni INT
)
 SELECT * FROM estudiante23

 CREATE TABLE inicio_sesion(
 pass_log nvarchar(10) primary key,
 user_log nvarchar(20)
 )

 INSERT INTO inicio_sesion VALUES('8989','Josue')

 SELECT * FROM inicio_sesion