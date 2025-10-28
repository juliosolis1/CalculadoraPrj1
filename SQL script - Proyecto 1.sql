--Crear DB
CREATE DATABASE CalculadoraDB_
ON PRIMARY
(
	NAME = 'Calculadora_Data',
	FILENAME = 'C:\SQL222\proyecto2\Data\Calculadora.mdf', --CREAR ESTAS CARPETAS ANTES DE CORRER LA CREACION DE LA BD
	SIZE = 10MB,
	MAXSIZE = 20MB,
	FILEGROWTH = 5MB
)
LOG ON
(
	NAME = 'Calculadora_Log',
	FILENAME = 'C:\SQL222\proyecto2\Log\Calculadora_Log.ldf', --CREAR ESTAS CARPETAS ANTES DE CORRER LA CREACION DE LA BD
	SIZE = 5MB,
	MAXSIZE = 10MB,
	FILEGROWTH = 2MB
)

USE CalculadoraDB_
GO

--CREAR TABLAS
CREATE TABLE Calculos (
	ID int identity (1,1) Primary key,
	Operacion Varchar(50) not null,
	Resultado Varchar(20) not null
)

SELECT * FROM Calculos


