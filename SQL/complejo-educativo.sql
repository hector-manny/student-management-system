CREATE DATABASE ComplejoEducativo
GO
USE ComplejoEducativo
GO

--Tabla Usuarios
CREATE TABLE Usuarios(
Usuario Varchar(20),
Contraseña varbinary,
TipoUsuario Varchar(25)
)

--Restricciones de la tabla usuarios
ALTER TABLE Usuarios
ADD CONSTRAINT U_USER
UNIQUE(Usuario)

--Tabla Registros
CREATE TABLE Registros(
NIE int PRIMARY KEY NOT NULL,
Turno Varchar(15) NOT NULL, 
PrimerNombre Varchar(25) NOT NULL,
SegundoNombre Varchar(25) NOT NULL,
PrimerApellido Varchar(25) NOT NULL,
SegundoApellido varchar(25) NOT NULL,
Edad int NOT NULL,
Telefono nchar(9) NOT NULL,
GradoDeEstudio varchar(25) NOT NULL,
RepiteGrado Nchar(2) NOT NULL,
Sexo Nchar(10) NOT NULL,
EstudioParvularia Nchar(2) NOT NULL,
IdPartida int,
IdDireccion int,
IdDiscapacidad int,
IdEncargado int,
IdActividadEconomica int,
IdCondicionFamiliar int,
IdCondicionMedica int
)

--Restricciones de la tabla Registros
ALTER TABLE Registros
ADD CONSTRAINT U_NIE
UNIQUE(NIE);

ALTER TABLE Registros
ADD CONSTRAINT CK_Edad
CHECK(Edad>0)

ALTER TABLE Registros
ADD CONSTRAINT CK_NIE
CHECK(NIE>0)

ALTER TABLE Registros
ADD CONSTRAINT CK_Repite
CHECK(RepiteGrado IN ('SI','NO','Si','No','si','no'))

ALTER TABLE Registros
ADD CONSTRAINT CK_Sexo
CHECK (Sexo IN ('MASCULINO','FEMENINO','Masculino','Femenino','masculino','femenino'))

ALTER TABLE Registros
ADD CONSTRAINT CK_Parvularia
CHECK(EstudioParvularia IN ('SI','NO','Si','No','si','no'))

--Tabla Notas
CREATE TABLE Notas(
IdNota int IDENTITY(1,1),
NIE int,
Nombre varchar(25),
GradoDeEstudio varchar(25),
IdMateria int,
Periodo int,
Actividad float,
NotaCuaderno float,
ExamenTrimestral float,
NotaFinal float,
PRIMARY KEY(NIE,IdMateria,Periodo,IdNota)
);

--Restricciones de la Tabla Notas
ALTER TABLE Notas 
ADD CONSTRAINT U_NIEN
UNIQUE(NIE)

ALTER TABLE Notas 
ADD CONSTRAINT CK_ID
CHECK(IdMateria>0)

ALTER TABLE Notas
ADD CONSTRAINT CK_Actividad
CHECK(Actividad>0)

ALTER TABLE Notas
ADD CONSTRAINT CK_NCuaderno
CHECK(NotaCuaderno>0)

ALTER TABLE Notas 
ADD CONSTRAINT CK_NExamen
CHECK(ExamenTrimestral>0)

ALTER TABLE Notas
ADD CONSTRAINT CK_NFinal
CHECK(NotaFinal>0)

ALTER TABLE Notas
ADD CONSTRAINT CK_Periodo
CHECK(Periodo>0)


--Tabla Partidas
CREATE TABLE Partidas(
IdPartida int PRIMARY KEY IDENTITY(1,1),
PoseePartida nchar(2)NOT NULL,
NumeroPartida int,
Folio int,
Tomo int,
Libro int,
LugarNacimiento varchar(20),
FechaNacimiento date,
NIE int
)

--Restricciones tabla Partidas
ALTER TABLE Partidas
ADD CONSTRAINT CK_Partida
CHECK(PoseePartida IN ('SI','NO','Si','No','si','no'))

ALTER TABLE Partidas 
ADD CONSTRAINT CK_numeropartida
CHECK(NumeroPartida>=0)

ALTER TABLE Partidas 
ADD CONSTRAINT CK_folio
CHECK(Folio>=0)

ALTER TABLE Partidas 
ADD CONSTRAINT CK_tomo
CHECK(Tomo>=0)

ALTER TABLE Partidas 
ADD CONSTRAINT CK_libro
CHECK(Libro>=0)

--Tabla Direcciones
CREATE TABLE Direcciones(
IdDireccion int PRIMARY KEY IDENTITY(1,1),
Departamento varchar(20) NOT NULL,
Municipio varchar(20) NOT NULL,
Zona varchar(8),
Complemento varchar(25) NOT NULL
);

--Restricciones Tabla Direcciones 
ALTER TABLE Direcciones
ADD CONSTRAINT CK_zona
CHECK(Zona IN ('Rural','Urbana','RURAL','URBANA','rural','urbana'))

--Tabla Discapacidades
CREATE TABLE Discapacidades(
IdDiscapacidad int PRIMARY KEY IDENTITY(1,1),
TipoDicapacidad varchar (25),
RecibeEducacionEspecial nchar(2)
);

--Restriccione de la tabla Discapacidades
ALTER TABLE Discapacidades
ADD CONSTRAINT CK_EducacionEspecial
CHECK(RecibeEducacionEspecial IN ('SI','NO','Si','No','si','no'))

--Tabla Encargados
CREATE TABLE Encargados(
IdEncargado int PRIMARY KEY IDENTITY(1,1),
Nombre varchar (20),
GradoDeEstudioQuePosee varchar(10),
Parentesco varchar(15),
SabeLeeryEscribir nchar(2)
);

--Restrcciones de la Tabla Encargados
ALTER TABLE Encargados
ADD CONSTRAINT CK_Leer
CHECK(SabeLeeryEscribir IN ('SI','NO','Si','No','si','no'))

-- Tabla Actividades Economicas
CREATE TABLE ActividadesEconomicas(
IdActividadEconomica int PRIMARY KEY IDENTITY(1,1),
TipoActividad varchar(20)
);

--Tabla Condiciones Familiares
CREATE TABLE CondicionesFamiliares(
IdCondicionFamiliar int PRIMARY KEY IDENTITY(1,1),
TipoCondicionFamiliar varchar(15)
);

--Tabla Condiciones Medicas
CREATE TABLE CondicionesMedicas(
IdCondicionMedica int PRIMARY KEY IDENTITY(1,1),
VacunasCompletas nchar(2),
ProblemaSalud nchar(2),
TipoProblemaSalud varchar(15)
);

--Restricciones tabla Condiciones Medicas
ALTER TABLE CondicionesMedicas
ADD CONSTRAINT CK_vacunas
CHECK(VacunasCompletas IN ('SI','NO','Si','No','si','no'))

ALTER TABLE CondicionesMedicas
ADD CONSTRAINT CK_problemaSalud
CHECK(ProblemaSalud IN ('SI','NO','Si','No','si','no'))

--FINALIZAN TABLAS DE REGISTRO DE ESTUDIANTES 

--Incian las tablas del control de notas 

--Tabla Salones
CREATE TABLE Salones(
IdSalon int PRIMARY KEY IDENTITY(1,1),
Grado varchar(10) NOT NULL,
Seccion varchar(10) NOT NULL,
Capacidad int NOT NULL,
IdDocente int
);

--Restriciones de la Tabla Salones
ALTER TABLE Salones 
ADD CONSTRAINT CK_capacidad
CHECK(Capacidad>0 AND Capacidad<=45)

--Tabla Docentes
CREATE TABLE Docentes(
IdDocente int PRIMARY KEY IDENTITY(1,1),
IdMateria int,
PrimerNombre Varchar(25) NOT NULL,
SegundoNombre Varchar(25) NOT NULL,
PrimerApellido Varchar(25) NOT NULL,
SegundoApellido varchar(25) NOT NULL,
Edad int NOT NULL,
Telefono nchar(9) NOT NULL,
NIP int,
AsignaturaQueImparte varchar(15) NOT NULL,
IdNotas int
);

--Restricciones de la Tabla Docente
ALTER TABLE Docentes 
ADD CONSTRAINT CK_edadD
CHECK(Edad>0)

ALTER TABLE Docentes 
ADD CONSTRAINT U_nip
UNIQUE(NIP)

--Tabla Materias
CREATE TABLE Materias(
IdMateria int IDENTITY (1,1) PRIMARY KEY,
NombreMateria Varchar(20) 
);

--Restricciones de la tabla Materias
ALTER TABLE Materias
ADD CONSTRAINT U_NombreMateria
UNIQUE(NombreMateria)

--Creando Relaciones
ALTER TABLE Notas 
ADD CONSTRAINT FK_NIE FOREIGN KEY(NIE) 
REFERENCES Registros(NIE) 
ON UPDATE 
CASCADE ON DELETE CASCADE;

ALTER TABLE Registros
ADD CONSTRAINT FK_partidas
FOREIGN KEY (IdPartida)
REFERENCES Partidas(IdPartida)
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE Registros
ADD CONSTRAINT FK_Direccion
FOREIGN KEY(IdDireccion)
REFERENCES Direcciones(IdDireccion)
ON DELETE CASCADE
ON UPDATE CASCADE;

ALTER TABLE Registros
ADD CONSTRAINT FK_Discapacidad
FOREIGN KEY(IdDiscapacidad)
REFERENCES Discapacidades(IdDiscapacidad)
ON DELETE CASCADE
ON UPDATE CASCADE;

ALTER TABLE Registros
ADD CONSTRAINT FK_Encargado
FOREIGN KEY(IdEncargado)
REFERENCES Encargados(IdEncargado)
ON DELETE CASCADE
ON UPDATE CASCADE;

ALTER TABLE Registros
ADD CONSTRAINT FK_ActividadEconomica
FOREIGN KEY(IdActividadEconomica)
REFERENCES ActividadesEconomicas(IdActividadEconomica)
ON DELETE CASCADE
ON UPDATE CASCADE;

ALTER TABLE Registros
ADD CONSTRAINT FK_CondicionFamiliar
FOREIGN KEY(IdCondicionFamiliar)
REFERENCES CondicionesFamiliares(IdCondicionFamiliar)
ON DELETE CASCADE
ON UPDATE CASCADE;

ALTER TABLE Registros
ADD CONSTRAINT FK_CondicionMedica
FOREIGN KEY(IdCondicionMedica)
REFERENCES CondicionesMedicas(IdCondicionMedica)
ON DELETE CASCADE
ON UPDATE CASCADE;


ALTER TABLE Salones 
ADD CONSTRAINT FK_Docente
FOREIGN KEY (IdDocente)
REFERENCES Docentes(IdDocente)
ON DELETE CASCADE 
ON UPDATE CASCADE;

ALTER TABLE Docentes
ADD CONSTRAINT FK_Materia
FOREIGN KEY(IdMateria)
REFERENCES Materias(IdMateria)
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE NOTAS 
ADD CONSTRAINT FK_IdMateria2
FOREIGN KEY(IdMateria)
REFERENCES Materias(IdMateria)
ON UPDATE CASCADE
ON DELETE CASCADE;

--Creando Procedimientos Almacenados
/*CREATE PROC InsertarTablaRegistros
@NIE INT,
@Turno varchar(15),
@PrimerNombre varchar(25),
@SegundoNombre varchar(25),
@PrimerApellido Varchar(25),
@SegundoApellido varchar(25),
@Edad int,
@Telefono nchar(9),
@GradoDeEstudio varchar(25),
@RepiteGrado Nchar(2),
@Sexo Nchar(10),
@EstudioParvularia Nchar(2),
@IdPartida int,
@IdDireccion int,
@IdDiscapacidad int,
@IdEncargado int,
@IdActividadEconomica int,
@IdCondicionFamiliar int,
@IdCondicionMedica int
AS
INSERT INTO Registros VALUES(
@NIE,
@Turno,
@PrimerNombre,
@SegundoNombre,
@PrimerApellido,
@SegundoApellido,
@Edad,
@Telefono,
@GradoDeEstudio,
@RepiteGrado,
@Sexo,
@EstudioParvularia,
@IdPartida,
@IdDireccion,
@IdDiscapacidad,
@IdEncargado,
@IdActividadEconomica,
@IdCondicionFamiliar,
@IdCondicionMedica)

CREATE PROC InsertarTablaNotas
@IdNota INT,
@NIE INT,
@IdMateria INT,
@Periodo INT,
@Actividad FLOAT,
@NotaCuaderno FLOAT,
@ExamenTrimestral FLOAT,
@NotaFinal FLOAT
AS
INSERT INTO Notas 
VALUES(
@IdNota,
@NIE,
@IdMateria,
@Periodo,
@Actividad,
@NotaCuaderno,
@NotaFinal)

CREATE PROC InsertarTablaPartidas
@IdPartida INT,
@PoseePartida NCHAR(2),
@Folio INT,
@Tomo INT,
@Libro INT,
@LugarNacimiento VARCHAR(20),
@FechaNacimiento DATE,
@NIE INT
AS
INSERT INTO Partidas 
VALUES(
@Idpartida,
@PoseePartida,
@Folio,@Tomo,
@Libro,
@LugarNacimiento,
@FechaNacimiento,
@NIE)

CREATE PROC InsertarTablaDirecciones
@IdDireccion INT,
@Departamento VARCHAR(20),
@Municipio VARCHAR(20),
@Zona VARCHAR(8),
@Complemento VARCHAR(25)
AS
INSERT INTO Direcciones 
VALUES(
@IdDireccion,
@Departamento,
@Municipio,
@Zona,
@Complemento)

CREATE PROC InsertarTablaDiscapacidades
@IdDiscapacidad INT,
@TipoDiscapacidad VARCHAR(25),
@RecibeEducacionEspecial NCHAR(2)
AS
INSERT INTO Discapacidades 
VALUES(
@IdDiscapacidad,
@TipoDiscapacidad,
@RecibeEducacionEspecial)

CREATE PROC InsertarTablaEncargados
@IdEncargado INT,
@Nombre VARCHAR(20),
@GradoDeEstudioQuePosee VARCHAR(10),
@Parentesco VARCHAR(15),
@SabeLeeryEscribir NCHAR(2)
AS
INSERT INTO Encargados 
VALUES(
@IdEncargado,
@Nombre,
@GradoDeEstudioQuePosee,
@Parentesco,
@SabeLeeryEscribir)

CREATE PROC InsertarTablaActividadesEconomicas
@IdActividadEconomica INT,
@TipoActividad VARCHAR(20)
AS
INSERT INTO ActividadesEconomicas 
VALUES(
@IdActividadEconomica,
@TipoActividad)

CREATE PROC InsertarTablaCondicionesFamiliares
@IdCondicionFamiliar INT,
@TipoCondicionFamiliar VARCHAR(15)
AS
INSERT INTO CondicionesFamiliares 
VALUES(
@IdCondicionFamiliar,
@TipoCondicionFamiliar)

CREATE PROC InsertarTablaCondicionesMedicas
@IdCondicionMedica INT,
@VacunasCompletas NCHAR(2),
@ProblemaSalud NCHAR(2),
@TipoProblemaSalud VARCHAR(15)
AS
INSERT INTO CondicionesMedicas 
VALUES(
@IdCondicionMedica,
@VacunasCompletas,
@ProblemaSalud,
@TipoProblemaSalud)

CREATE PROC InsertarTablaSalones
@IdSalon INT,
@Grado VARCHAR(10),
@Seccion VARCHAR(10),
@Capacidad INT,
@IdDocente INT
AS
INSERT INTO Salones VALUES(@IdSalon,@Grado,@Seccion,@Capacidad,@IdDocente)

CREATE PROC InsertarTablaDocentes
@IdDocente INT,
@IdMateria INT,
@PrimerNombre VARCHAR(25),
@SegundoNombre VARCHAR(25),
@PrimerApellido VARCHAR(25),
@SegundoApellido VARCHAR(25),
@Edad INT,
@Telefono NCHAR(9),
@NIP INT,
@AsignaturaQueImparte VARCHAR(15),
@IdNotas INT
AS
INSERT INTO Docentes 
VALUES(
@IdDocente,
@IdMateria,
@PrimerNombre,
@SegundoNombre,
@PrimerApellido,
@SegundoApellido,
@Edad,
@Telefono,
@NIP,
@AsignaturaQueImparte,
@IdNotas)

CREATE PROC InsertarTablaMaterias
@NombreMateria VARCHAR(20)
AS
INSERT INTO Materias 
VALUES(@NombreMateria)

execute InsertarTablaMaterias 'Ciencias'

select*from Materias
select*from Notas*/