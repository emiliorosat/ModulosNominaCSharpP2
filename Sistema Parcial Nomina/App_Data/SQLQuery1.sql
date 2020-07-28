create table Empleados (
Id int identity not null primary key,
Cedula nvarchar(15) not null,
Nombre nvarchar(50),
Apellido nvarchar (70),
Telefono nvarchar(12),
Email nvarchar(50),
Departamento nvarchar(50),
Cargo nvarchar(100),
Fecha_ingreso date,
Salario float,
Estado int
)

create table Nomina (
Id int identity not null primary key,
Ano int,
Mes nvarchar(15),
Fecha date,
Nomina float
)