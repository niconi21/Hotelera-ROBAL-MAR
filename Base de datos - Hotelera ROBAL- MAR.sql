CREATE DATABASE Hotelera_ROBAL_MAR;
GO
USE Hotelera_ROBAL_MAR;
GO
CREATE TABLE Piso(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	numero INT NOT NULL);
GO
CREATE TABLE Habitacion(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	numero INT NOT NULL,
	estatus VARCHAR(13) NOT NULL,
	tipo VARCHAR(10) NOT NULL,
	precio SMALLMONEY NOT NULL,
	piso INT NOT NULL CONSTRAINT fk_habitacion_esta_piso REFERENCES Piso);
GO
Create table Direccion(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	ciudad VARCHAR(30) NOT NULL,
	colonia VARCHAR(30) NOT NULL,
	calle VARCHAR(30) NOT NULL,
	numInt INT NOT NULL,
	numExt INT,
	referencias VARCHAR(100) NOT NULL,
	cp VARCHAR(8) NOT NULL)
GO
CREATE TABLE Personal(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	tipoPersonal bit NOT NULL,
	nombre VARCHAR(30) NOT NULL,
	apepat VARCHAR(30) NOT NULL,
	apemat VARCHAR(30) NOT NULL,
	usuario VARCHAR(30) NOT NULL,
	clave VARCHAR(30) NOT NULL,
	curp VARCHAR(18) NOT NULL,
	direccion INT NOT NULL CONSTRAINT fk_Personal_tiene_direccion REFERENCES Direccion);
GO
CREATE TABLE Telefono(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	tipoTelefono VARCHAR(10) NOT NULL,
	telefono VARCHAR(12) NOT NULL,
	Personal INT NOT NULL CONSTRAINT fk_telefono_pertenece_Personal REFERENCES Personal);
GO
CREATE TABLE Cliente(
	id INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	nombre VARCHAR(30) NOT NULL,
	apepat VARCHAR(30) NOT NULL,
	apemat VARCHAR(30) NOT NULL,
	curp VARCHAR(18) NOT NULL);
GO
CREATE TABLE Historial(
	id INT Identity(0,1) PRIMARY KEY NOT NULL,
	cliente INT NOT NULL CONSTRAINT fk_historial_tiene_cliente REFERENCES Cliente,
	Personal INT NOT NULL CONSTRAINT fk_historial_tiene_Personal REFERENCES Personal, 
	habitacion INT NOT NULL CONSTRAINT fk_historial_tiene_habitacion REFERENCES Habitacion,
	pagoPorDia SMALLMoney NOT NULL,
	montoTotal SMALLMoney NOT NULL,
	fechaInicio DATE NOT NULL,
	fechaFinal DATE);
