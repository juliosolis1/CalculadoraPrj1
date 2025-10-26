--Crear DB
CREATE DATABASE CalculadoraDB
ON PRIMARY
(
	NAME = 'Calculadora_Data',
	FILENAME = 'C:\SQL222\proyecto\Data\Calculadora.mdf',
	SIZE = 10MB,
	MAXSIZE = 20MB,
	FILEGROWTH = 5MB
)
LOG ON
(
	NAME = 'Calculadora_Log',
	FILENAME = 'C:\SQL222\proyecto\Log\Calculadora_Log.ldf',
	SIZE = 5MB,
	MAXSIZE = 10MB,
	FILEGROWTH = 2MB
)

USE CalculadoraDB 
GO

--CREAR TABLAS
CREATE TABLE Calculos (
	ID int identity (1,1) Primary key,
	Operacion Varchar(50) not null,
	Resultado Varchar(20) not null
)

--CREAR LOGIN PARA CONECTAR DB
CREATE LOGIN calculadora_user WITH PASSWORD = 'Calc2025!';
USE CalculadoraDB;
CREATE USER calculadora_user FOR LOGIN calculadora_user;
ALTER ROLE db_owner ADD MEMBER calculadora_user;

SELECT * FROM Calculos
