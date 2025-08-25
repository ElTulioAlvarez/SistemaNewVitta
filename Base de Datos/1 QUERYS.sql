create database NewVitta;

use NewVitta;
use Master;

drop table Usuarios;

drop database NewVitta;

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
    FechaNacimiento DATE,
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

INSERT INTO Psicologos (Nombre, CedulaProfesional, Especialidad, Telefono)
VALUES 
('María Fernanda López Ramírez', 'PSI-4587321', 'Psicología Clínica y Adicciones', '442-315-7890'),
('José Antonio García Torres', 'PSI-4829107', 'Terapia Cognitivo-Conductual', '444-222-4567');

INSERT INTO Doctores (Nombre, CedulaProfesional, Especialidad, Telefono)
VALUES 
('Dr. Alejandro Martínez Ríos', 'MED-5567810', 'Psiquiatría', '442-500-7788'),
('Dra. Lucía Hernández Vega', 'MED-6021985', 'Medicina Interna', '443-120-3345');

INSERT INTO Medicamentos (Nombre, Dosis, Frecuencia)
VALUES
('Sertralina', '50 mg', '1 vez al día'),
('Quetiapina', '100 mg', 'Noche'),
('Clonazepam', '0.5 mg', 'Cada 12 horas'),
('Acetaminofén', '500 mg', 'Cada 8 horas si hay dolor'),
('Omeprazol', '20 mg', 'Antes del desayuno');

INSERT INTO Internos (Nombre, FechaNacimiento, Ocupacion, FamiliarResponsable, FechaIngreso, IdPsicologo, IdDoctor)
VALUES
('Carlos Eduardo Ramírez López', '2025-07-01', 'Albañil', 'Martha López Ramírez', '2025-07-01', 1, 1),
('Luis Fernando Torres Méndez', '2025-07-01', 'Chofer de carga', 'Ana Méndez Pérez', '2025-06-15', 2, 2),
('Jorge Iván Hernández Ruiz', '2025-07-01', 'Carpintero', 'Rosa Ruiz Gutiérrez', '2025-05-20', 1, 2),
('Mario Alberto Díaz Ortega', '2025-07-01', 'Estudiante', 'Gabriela Ortega Gómez', '2025-07-10', 2, 1),
('Ricardo Alejandro Vargas Soto', '2025-07-01', 'Vendedor ambulante', 'Sofía Soto Martínez', '2025-06-05', 1, 1),
('Hugo Manuel Jiménez Chávez', '2025-07-01', 'Mecánico', 'Lucía Chávez López', '2025-06-28', 2, 2),
('Pedro Antonio González Pineda', '2025-07-01', 'Taxista', 'Teresa Pineda Morales', '2025-07-12', 1, 2),
('Ernesto Javier Morales Peña', '2025-07-01', 'Cocinero', 'María Peña Flores', '2025-07-18', 2, 1);

INSERT INTO InternosMedicamentos (IdInterno, IdMedicamento)
VALUES
(1, 1), -- Carlos -> Sertralina
(1, 4), -- Carlos -> Acetaminofén
(2, 2), -- Luis -> Quetiapina
(3, 3), -- Jorge -> Clonazepam
(4, 1), -- Mario -> Sertralina
(5, 5), -- Ricardo -> Omeprazol
(6, 2), -- Hugo -> Quetiapina
(6, 3), -- Hugo -> Clonazepam
(7, 4), -- Pedro -> Acetaminofén
(8, 1), -- Ernesto -> Sertralina
(8, 5); -- Ernesto -> Omeprazol

INSERT INTO Mensualidades (IdInterno, FechaPago, Monto, Observaciones)
VALUES
(1, '2025-07-05', 3500.00, 'Primer mes pagado a tiempo'),
(2, '2025-06-20', 3400.00, 'Pago con descuento por pronto pago'),
(3, '2025-05-25', 3500.00, 'Pago realizado en efectivo'),
(4, '2025-07-12', 3500.00, 'Familia realizó transferencia bancaria'),
(5, '2025-06-10', 3400.00, 'Se otorgó apoyo económico parcial'),
(6, '2025-07-01', 3500.00, 'Pago puntual'),
(7, '2025-07-15', 3500.00, 'Pago en efectivo'),
(8, '2025-07-20', 3500.00, 'Pago realizado por la madre');

select * from internos;
select * from InternosMedicamentos;