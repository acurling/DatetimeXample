CREATE DATABASE DB1
GO

USE DB1
GO

CREATE TABLE alumno (
   id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) NOT NULL,
	FECHA DATETIME
);

