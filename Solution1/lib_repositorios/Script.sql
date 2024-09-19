CREATE DATABASE Db_Biblioteca
GO

USE Db_Biblioteca
GO

CREATE TABLE [Personas](
	[Id] INT NOT NULL IDENTITY(1,1),
	[Cedula] BIGINT NOT NULL UNIQUE,
	[Nombre] VARCHAR(80)NOT NULL,
	[Numero] BIGINT,
	CONSTRAINT [PK_PERSONAS] PRIMARY KEY CLUSTERED ([Id]),
);
go

CREATE TABLE [Usuarios](
	[Id] INT NOT NULL IDENTITY(1,1),
	[Email] VARCHAR(40) NOT NULL,
	[Contraseña] VARCHAR(20)NOT NULL,
	[Cod_Usuario] INT NOT NULL UNIQUE,
	[Persona] INT,
	CONSTRAINT [FK_Usuarios_Personas] FOREIGN KEY ([Persona]) REFERENCES [Personas] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED ([Id])
);
go

CREATE TABLE [Prestamos](
	[Id] INT NOT NULL IDENTITY (1, 1),
	[Fecha_Inicio] SMALLDATETIME NOT NULL,
	[Usuario] INT NOT NULL,
	CONSTRAINT [FK_Prestamos_Usuarios] FOREIGN KEY ([Usuario]) REFERENCES [Usuarios] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT [PK_Prestamos] PRIMARY KEY CLUSTERED ([Id])
);
go

CREATE TABLE [Libros](
	[Id] INT NOT NULL IDENTITY(1,1),
	[Nombre_Libro] VARCHAR(100) NOT NULL,
	[Fecha_Publicacion] SMALLDATETIME,
	[Autor] VARCHAR(40),
	[Cod_Libro] INT NOT NULL UNIQUE,
	CONSTRAINT [PK_Libros] PRIMARY KEY CLUSTERED ([Id])
);
go

CREATE TABLE [Copias_Libros](
	[Id] INT NOT NULL IDENTITY (1, 1),
	[Notas] VARCHAR(255),
	[Estado] BIT DEFAULT 0,
	[Libro] INT,
	CONSTRAINT [FK_Copias_Libros] FOREIGN KEY ([Libro]) REFERENCES [Libros] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT [PK_Copias] PRIMARY KEY CLUSTERED ([Id])
)
go

CREATE TABLE [Detalles](
	[Id] INT NOT NULL IDENTITY (1, 1),
	[Fecha_Final] DATE,
	[Prestamo] INT NOT NULL,
	[Copia] INT NOT NULL,
	CONSTRAINT [FK_Detalles_Prestamos] FOREIGN KEY ([Prestamo]) REFERENCES [Prestamos] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT [FK_Detalles_Copias] FOREIGN KEY ([Copia]) REFERENCES [Copias_Libros] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT [PK_Detalles] PRIMARY KEY CLUSTERED ([Id])
)
go


INSERT INTO [Personas]([Cedula],[Nombre],[Numero]) VALUES
(15123,'Esteban Quintero Yepes',312344874),
(51232,'Juan Esteban Zapata Yepes',532435464),
(23433,'Esteban David Quintero Puerta',234354643),
(65413,'Esteban Emanuel Quintero Yepes',685639844),
(76454,'Angie Esteban Quintero',312344876)
SELECT * FROM [PERSONAS]
go

INSERT INTO [Usuarios]([Cod_Usuario],[Email],[Contraseña],[Persona])VALUES
(235765,'Example@correo.com','Holamundo',1),
(543214,'Example@correo.com','Holam',2),
(6543269,'Example@correo.com','Holapa',3),
(9005566,'Example@correo.com','Holasugra',4),
(987653,'Example@correo.com','Holainfiel',5)
SELECT * FROM [USUARIOS]
go

INSERT INTO [Libros]([Cod_Libro],[Nombre_Libro],[Fecha_Publicacion],[Autor]) VALUES
(23468,'Titulo1','1930-11-01','Silleban'),
(12454,'Titulo2','1920-12-10','Nevereban'),
(965594,'Titulo3','1910-09-21','Noseban'),
(10872,'Titulo4','1940-07-23','Guerrilleban'),
(874723,'Titulo5','1950-07-22','Mariguneban')
SELECT * FROM [LIBROS]
go

INSERT INTO [Copias_Libros]([Notas],[Estado],[Libro])VALUES
('A',1,1),
('T',0,2),
('H',1,5),
('J',0,2),
('K',1,3),
('C',1,3)
SELECT * FROM [Copias_Libros]
go

INSERT INTO [Prestamos]([Fecha_Inicio],[Usuario])VALUES
(GETDATE(),1),
(GETDATE(),2),
(GETDATE(),5),
(GETDATE(),3)
SELECT * FROM [PRESTAMOS]
go

INSERT INTO [Detalles]([Fecha_Final],[Prestamo],[Copia])VALUES
('2002-03-15',1,4),
('1980-03-25',1,3),
('2002-11-15',2,2),
('1850-03-25',2,5),
('1980-03-25',4,6),
('2001-12-12',3,1)
SELECT * FROM [DETALLES]
go
