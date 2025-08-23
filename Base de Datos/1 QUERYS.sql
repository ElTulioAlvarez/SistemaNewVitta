create database NewVitta;

use NewVitta;

drop table Usuarios;

create table Usuarios(
id_usuario int primary key identity,
nombre Varchar(50),
usuario Varchar(50),
pass Varchar(50),
rol varchar(50),
);

insert into Usuarios(nombre, usuario, pass, rol)
values('Marco Tulio Alvarez Barajas', 'Tulio', '9805', 'Encargado');

CREATE TABLE Psicologos (
    IdPsicologo INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    CedulaProfesional NVARCHAR(50),
    Especialidad NVARCHAR(100),
    Telefono NVARCHAR(20)
);

-- Tabla de Doctores
CREATE TABLE Doctores (
    IdDoctor INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    CedulaProfesional NVARCHAR(50),
    Especialidad NVARCHAR(100),
    Telefono NVARCHAR(20)
);

-- Tabla de Medicamentos
CREATE TABLE Medicamentos (
    IdMedicamento INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Dosis NVARCHAR(50),
    Frecuencia NVARCHAR(50)
);

-- Tabla de Internos
CREATE TABLE Internos (
    IdInterno INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Edad INT,
    Ocupacion NVARCHAR(100),
    FamiliarResponsable NVARCHAR(100),
    FechaIngreso DATE,
    IdPsicologo INT FOREIGN KEY REFERENCES Psicologos(IdPsicologo),
    IdDoctor INT FOREIGN KEY REFERENCES Doctores(IdDoctor)
);

-- Relación Interno - Medicamento (muchos a muchos)
CREATE TABLE InternosMedicamentos (
    IdInterno INT FOREIGN KEY REFERENCES Internos(IdInterno),
    IdMedicamento INT FOREIGN KEY REFERENCES Medicamentos(IdMedicamento),
    PRIMARY KEY (IdInterno, IdMedicamento)
);

-- Tabla de mensualidades (pagos por mes)
CREATE TABLE Mensualidades (
    IdMensualidad INT PRIMARY KEY IDENTITY,
    IdInterno INT FOREIGN KEY REFERENCES Internos(IdInterno),
    FechaPago DATE,
    Monto DECIMAL(10,2),
    Observaciones NVARCHAR(200)
);