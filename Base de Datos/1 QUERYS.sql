create database NewVitta;

use NewVitta;
use Master;

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
    Telefono NVARCHAR(20),
    id_usuario INT FOREIGN KEY REFERENCES Usuarios(id_usuario)
);

-- Tabla de Doctores
CREATE TABLE Doctores (
    IdDoctor INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    CedulaProfesional NVARCHAR(50),
    Especialidad NVARCHAR(100),
    Telefono NVARCHAR(20),
    id_usuario INT FOREIGN KEY REFERENCES Usuarios(id_usuario)
);

-- Tabla de Medicamentos
CREATE TABLE Medicamentos (
    IdMedicamento INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Dosis NVARCHAR(50),
    Frecuencia NVARCHAR(50),
    id_usuario INT FOREIGN KEY REFERENCES Usuarios(id_usuario)
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
    IdDoctor INT FOREIGN KEY REFERENCES Doctores(IdDoctor),
    id_usuario INT FOREIGN KEY REFERENCES Usuarios(id_usuario)
);

-- Relación Interno - Medicamento (muchos a muchos)
CREATE TABLE InternosMedicamentos (
    IdInterno INT FOREIGN KEY REFERENCES Internos(IdInterno),
    IdMedicamento INT FOREIGN KEY REFERENCES Medicamentos(IdMedicamento),
    PRIMARY KEY (IdInterno, IdMedicamento),
    id_usuario INT FOREIGN KEY REFERENCES Usuarios(id_usuario)
);

-- Tabla de mensualidades (pagos por mes)
CREATE TABLE Mensualidades (
    IdMensualidad INT PRIMARY KEY IDENTITY,
    IdInterno INT FOREIGN KEY REFERENCES Internos(IdInterno),
    FechaPago DATE,
    Monto DECIMAL(10,2),
    Observaciones NVARCHAR(200),
    id_usuario INT FOREIGN KEY REFERENCES Usuarios(id_usuario)
);

INSERT INTO Psicologos (Nombre, CedulaProfesional, Especialidad, Telefono, id_usuario)
VALUES 
('María Fernanda López Ramírez', 'PSI-4587321', 'Psicología Clínica y Adicciones', '442-315-7890', 1),
('José Antonio García Torres', 'PSI-4829107', 'Terapia Cognitivo-Conductual', '444-222-4567', 1);

INSERT INTO Doctores (Nombre, CedulaProfesional, Especialidad, Telefono, id_usuario)
VALUES 
('Dr. Alejandro Martínez Ríos', 'MED-5567810', 'Psiquiatría', '442-500-7788', 1),
('Dra. Lucía Hernández Vega', 'MED-6021985', 'Medicina Interna', '443-120-3345', 1);

INSERT INTO Medicamentos (Nombre, Dosis, Frecuencia, id_usuario)
VALUES
('Sertralina', '50 mg', '1 vez al día', 1),
('Quetiapina', '100 mg', 'Noche', 1),
('Clonazepam', '0.5 mg', 'Cada 12 horas', 1),
('Acetaminofén', '500 mg', 'Cada 8 horas si hay dolor', 1),
('Omeprazol', '20 mg', 'Antes del desayuno', 1);

INSERT INTO Internos (Nombre, FechaNacimiento, Ocupacion, FamiliarResponsable, FechaIngreso, IdPsicologo, IdDoctor, id_usuario)
VALUES
('Carlos Eduardo Ramírez López', '2025-07-01', 'Albañil', 'Martha López Ramírez', '2025-07-01', 1, 1, 1),
('Luis Fernando Torres Méndez', '2025-07-01', 'Chofer de carga', 'Ana Méndez Pérez', '2025-06-15', 2, 2, 1),
('Jorge Iván Hernández Ruiz', '2025-07-01', 'Carpintero', 'Rosa Ruiz Gutiérrez', '2025-05-20', 1, 2, 1),
('Mario Alberto Díaz Ortega', '2025-07-01', 'Estudiante', 'Gabriela Ortega Gómez', '2025-07-10', 2, 1, 1),
('Ricardo Alejandro Vargas Soto', '2025-07-01', 'Vendedor ambulante', 'Sofía Soto Martínez', '2025-06-05', 1, 1, 1),
('Hugo Manuel Jiménez Chávez', '2025-07-01', 'Mecánico', 'Lucía Chávez López', '2025-06-28', 2, 2, 1),
('Pedro Antonio González Pineda', '2025-07-01', 'Taxista', 'Teresa Pineda Morales', '2025-07-12', 1, 2, 1),
('Ernesto Javier Morales Peña', '2025-07-01', 'Cocinero', 'María Peña Flores', '2025-07-18', 2, 1, 1);

INSERT INTO InternosMedicamentos (IdInterno, IdMedicamento, id_usuario)
VALUES
(1, 1, 1), -- Carlos -> Sertralina
(1, 4, 1), -- Carlos -> Acetaminofén
(2, 2, 1), -- Luis -> Quetiapina
(3, 3, 1), -- Jorge -> Clonazepam
(4, 1, 1), -- Mario -> Sertralina
(5, 5, 1), -- Ricardo -> Omeprazol
(6, 2, 1), -- Hugo -> Quetiapina
(6, 3, 1), -- Hugo -> Clonazepam
(7, 4, 1), -- Pedro -> Acetaminofén
(8, 1, 1), -- Ernesto -> Sertralina
(8, 5, 1); -- Ernesto -> Omeprazol

INSERT INTO Mensualidades (IdInterno, FechaPago, Monto, Observaciones, id_usuario)
VALUES
(1, '2025-07-05', 3500.00, 'Primer mes pagado a tiempo', 1),
(2, '2025-06-20', 3400.00, 'Pago con descuento por pronto pago', 1),
(3, '2025-05-25', 3500.00, 'Pago realizado en efectivo', 1),
(4, '2025-07-12', 3500.00, 'Familia realizó transferencia bancaria', 1),
(5, '2025-06-10', 3400.00, 'Se otorgó apoyo económico parcial', 1),
(6, '2025-07-01', 3500.00, 'Pago puntual', 1),
(7, '2025-07-15', 3500.00, 'Pago en efectivo', 1),
(8, '2025-07-20', 3500.00, 'Pago realizado por la madre', 1);

select * from internos;
select * from Doctores;
select * from Psicologos;
select * from InternosMedicamentos;
select * from Usuarios;