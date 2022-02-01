USE Capacitacion
create table saldos(
  id int PRIMARY KEY IDENTITY NOT NULL,
  nombre varchar(100) NULL,
  saldo int
 );

 create table Transacciones(
  id int PRIMARY KEY IDENTITY NOT NULL,
  idOrigen int NOT NULL,
  idDestino int NOT NULL,
  monto int 
 );
