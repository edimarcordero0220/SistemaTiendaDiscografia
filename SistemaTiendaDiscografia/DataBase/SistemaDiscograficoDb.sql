use SistemaDiscograficoDb;

create table Clientes(
 IdCliente int identity (1,1) primary key,
 NombreCliente varchar(30),
 ApellidoCliente varchar (30),
 DireccionCliente varchar( 30),
 CedulaCliente varchar(30),
 FechaCreacion datetime,
 Activo bit,
 UsuarioModificador varchar (30)
);