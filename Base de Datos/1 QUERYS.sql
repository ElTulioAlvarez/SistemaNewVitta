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

select * from Usuarios;