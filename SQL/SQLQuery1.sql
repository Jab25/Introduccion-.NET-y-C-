CREATE DATABASE Capacitacion

USE Capacitacion

CREATE TABLE Estados(
id int primary key identity (1,1),
nombre varchar(100),
);

CREATE TABLE EstatusAlumnos(
id smallint primary key,
Clave char(10) not null,
Nombre varchar(100) not null
);

CREATE TABLE CatCursos(
id smallint primary key Identity,
clave varchar(15) not null,
nombre varchar(50) not null,
descripcion varchar(1000),
horas tinyint,
idPreRequisito smallint,
activo bit
);

CREATE TABLE Cursos(
id smallint primary key Identity (1,1),
idCatCurso smallint,
fechaInicio date,
fechatermino date,
activo bit,
);

CREATE TABLE Alumnos(
id int primary key Identity (1,1),
nombre varchar(60) not null,
primerApellido varchar(50) not null,
segundoApellido varchar(50),
correo varchar(80) not null,
telefono nchar(10) not null,
fechaNacimiento date,
curp char(18) not null,
sueldo decimal(9,2),
idEstadoOrigen int not null,
idEstatus smallint not null,
);

CREATE TABLE Instructores(
id smallint primary key Identity (1,1),
nombre varchar(60) not null,
primerApellido varchar(50)not null,
segundoApellido varchar(50),
correo varchar(80) not null,
telefono nchar(10) not null,
fechaNacimiento date not null,
rfc char(13) not null,
curp char(18) not null,
cuotaHora decimal(9, 2) not null,
activo bit not null,
);

CREATE TABLE CursosAlumnos(
id int primary key Identity (1,1),
idCurso smallint not null,
idAlumno int not null,
fechaInscripcion date not null,
fechaBaja date,
calificacion tinyint,
);

CREATE TABLE CursosInstructores(
id int primary key Identity (1,1),
idCurso smallint not null,
idInstructor int not null,
fechaContratacion date
);

CREATE TABLE AlumnosBaja(
id int primary key Identity (1,1),
nombre varchar(60) not null,
primerApellido varchar(50) not null,
segundoApellido varchar(50),
fechaBaja datetime not null
);