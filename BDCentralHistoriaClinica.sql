USE [master]
GO
/****** Object:  Database [HistoriaClinica]    Script Date: 25/11/2018 21:39:36 ******/
CREATE DATABASE [HistoriaClinica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HistoriaClinica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HistoriaClinica.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HistoriaClinica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HistoriaClinica_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HistoriaClinica] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HistoriaClinica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HistoriaClinica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HistoriaClinica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HistoriaClinica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HistoriaClinica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HistoriaClinica] SET ARITHABORT OFF 
GO
ALTER DATABASE [HistoriaClinica] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [HistoriaClinica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HistoriaClinica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HistoriaClinica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HistoriaClinica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HistoriaClinica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HistoriaClinica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HistoriaClinica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HistoriaClinica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HistoriaClinica] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HistoriaClinica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HistoriaClinica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HistoriaClinica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HistoriaClinica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HistoriaClinica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HistoriaClinica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HistoriaClinica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HistoriaClinica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HistoriaClinica] SET  MULTI_USER 
GO
ALTER DATABASE [HistoriaClinica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HistoriaClinica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HistoriaClinica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HistoriaClinica] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HistoriaClinica] SET DELAYED_DURABILITY = DISABLED 
GO
USE [HistoriaClinica]
GO
/****** Object:  Schema [m2ss]    Script Date: 25/11/2018 21:39:36 ******/
CREATE SCHEMA [m2ss]
GO
/****** Object:  Schema [mydb]    Script Date: 25/11/2018 21:39:36 ******/
CREATE SCHEMA [mydb]
GO
/****** Object:  Table [mydb].[afiliacion]    Script Date: 25/11/2018 21:39:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[afiliacion](
	[Persona_id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Vencimiento] [date] NULL,
	[Num_Afiliado] [nvarchar](45) NULL,
	[ObraSocial_id] [int] NOT NULL,
	[Persona_Persona_id] [int] NOT NULL,
 CONSTRAINT [PK_afiliacion_Persona_id] PRIMARY KEY CLUSTERED 
(
	[Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[antecedentes_familiares]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[antecedentes_familiares](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[Diabetes] [smallint] NOT NULL,
	[Cancer] [smallint] NOT NULL,
	[Obesidad] [smallint] NOT NULL,
	[Cardiovasculares] [smallint] NOT NULL,
	[Alcoholismo] [smallint] NOT NULL,
	[Muertes_Prematuras] [smallint] NOT NULL,
	[Paciente_idPaciente] [int] NOT NULL,
 CONSTRAINT [PK_antecedentes_familiares_idPaciente] PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[antecedentes_patologicos]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[antecedentes_patologicos](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[Hepatitis] [smallint] NOT NULL,
	[Diabetes] [smallint] NOT NULL,
	[Hipertension] [smallint] NOT NULL,
	[Epilepsia] [smallint] NOT NULL,
	[ETS] [smallint] NOT NULL,
	[Asma] [smallint] NOT NULL,
	[Alergias] [smallint] NOT NULL,
	[Antecedentes_Quirugicos] [smallint] NOT NULL,
	[Otros] [nvarchar](45) NOT NULL,
	[Paciente_idPaciente] [int] NOT NULL,
 CONSTRAINT [PK_antecedentes_patologicos_idPaciente] PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[antecedentes_psicologicos]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[antecedentes_psicologicos](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[Anciedad] [smallint] NOT NULL,
	[Depresion] [smallint] NOT NULL,
	[Bipolaridad] [smallint] NOT NULL,
	[Esquizofrenia] [smallint] NOT NULL,
	[Fobias] [smallint] NOT NULL,
	[Psicosis] [smallint] NOT NULL,
	[Otros] [nvarchar](45) NOT NULL,
	[Paciente_idPaciente] [int] NOT NULL,
 CONSTRAINT [PK_antecedentes_psicologicos_idPaciente] PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[barrio]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[barrio](
	[Persona_id] [int] IDENTITY(1,1) NOT NULL,
	[Barrio] [nvarchar](45) NOT NULL,
	[Localidad] [nvarchar](45) NOT NULL,
	[Persona_Persona_id] [int] NOT NULL,
	[Ciudad_Persona_id] [int] NOT NULL,
 CONSTRAINT [PK_barrio_Persona_id] PRIMARY KEY CLUSTERED 
(
	[Persona_id] ASC,
	[Persona_Persona_id] ASC,
	[Ciudad_Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[calle]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[calle](
	[Persona_id] [int] IDENTITY(1,1) NOT NULL,
	[Calle] [nvarchar](45) NOT NULL,
	[Numero] [nvarchar](45) NOT NULL,
	[Persona_Persona_id] [int] NOT NULL,
	[Barrio_Persona_id] [int] NOT NULL,
	[Barrio_Persona_Persona_id] [int] NOT NULL,
 CONSTRAINT [PK_calle_Persona_id] PRIMARY KEY CLUSTERED 
(
	[Persona_id] ASC,
	[Persona_Persona_id] ASC,
	[Barrio_Persona_id] ASC,
	[Barrio_Persona_Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[ciudad]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[ciudad](
	[Persona_id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Ciudad] [nvarchar](45) NOT NULL,
	[Provincia_Persona_id] [int] NOT NULL,
 CONSTRAINT [PK_ciudad_Persona_id] PRIMARY KEY CLUSTERED 
(
	[Persona_id] ASC,
	[Provincia_Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[doctor]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[doctor](
	[Doctor_Id] [int] IDENTITY(1,1) NOT NULL,
	[Num_Matricula] [nvarchar](45) NOT NULL,
	[Cuit/Cuil] [nvarchar](45) NOT NULL,
	[Especialidad] [nvarchar](45) NOT NULL,
	[Persona_Persona_id] [int] NOT NULL,
 CONSTRAINT [PK_doctor_Doctor_Id] PRIMARY KEY CLUSTERED 
(
	[Doctor_Id] ASC,
	[Persona_Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[domicilio]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[domicilio](
	[Persona_id] [int] IDENTITY(1,1) NOT NULL,
	[Calle] [nchar](45) NOT NULL,
	[Numero] [int] NULL,
	[Barrio] [nvarchar](45) NOT NULL,
	[Prov_Residencia] [nchar](45) NOT NULL,
	[Localidad] [nchar](45) NOT NULL,
	[Codigo_Postal] [int] NOT NULL,
 CONSTRAINT [PK_domicilio_Persona_id] PRIMARY KEY CLUSTERED 
(
	[Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[emergencia]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[emergencia](
	[Persona_id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](45) NOT NULL,
	[Tel_Emergencia] [nvarchar](45) NOT NULL,
	[Nombre_Emergencia] [nchar](45) NOT NULL,
	[Apellido_Emerg] [nchar](45) NOT NULL,
	[Direccion_Emerg] [nvarchar](45) NOT NULL,
	[Persona_Persona_id] [int] NOT NULL,
 CONSTRAINT [PK_emergencia_Persona_id] PRIMARY KEY CLUSTERED 
(
	[Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[habitos_toxicos]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[habitos_toxicos](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[Alcohol] [smallint] NOT NULL,
	[Tabaco] [smallint] NOT NULL,
	[Aspirinas] [smallint] NOT NULL,
	[Tranquilizantes] [smallint] NOT NULL,
	[Excitantes] [smallint] NOT NULL,
	[Otros] [smallint] NOT NULL,
	[Paciente_idPaciente] [int] NOT NULL,
 CONSTRAINT [PK_habitos_toxicos_idPaciente] PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[institucion]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[institucion](
	[Doctor_id] [int] IDENTITY(1,1) NOT NULL,
	[Institucion] [nvarchar](45) NULL,
	[Calle_Institucion] [nvarchar](45) NULL,
	[Num_calle] [nvarchar](45) NULL,
 CONSTRAINT [PK_institucion_Doctor_id] PRIMARY KEY CLUSTERED 
(
	[Doctor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[institucion_has_doctor]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[institucion_has_doctor](
	[Institucion_Doctor_id] [int] NOT NULL,
	[Doctor_Doctor_Id] [int] NOT NULL,
 CONSTRAINT [PK_institucion_has_doctor_Institucion_Doctor_id] PRIMARY KEY CLUSTERED 
(
	[Institucion_Doctor_id] ASC,
	[Doctor_Doctor_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[obrasocial]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[obrasocial](
	[Persona_id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_O.Social] [nvarchar](1000) NOT NULL,
	[telefono] [nvarchar](45) NULL,
 CONSTRAINT [PK_obrasocial_Persona_id] PRIMARY KEY CLUSTERED 
(
	[Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[paciente]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[paciente](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[PesoActual] [nvarchar](45) NOT NULL,
	[Altura] [nvarchar](45) NOT NULL,
	[GrupoSanguineo] [nvarchar](45) NOT NULL,
	[Peso_Habitual] [nvarchar](45) NOT NULL,
	[CreenciaReligiosa] [nvarchar](45) NOT NULL,
	[Vacunas_Completo] [nvarchar](45) NOT NULL,
	[Vacunas_faltantes] [nvarchar](45) NULL,
	[Persona_Persona_id] [int] NOT NULL,
	[TomaMedicamentos] [smallint] NOT NULL,
	[Pacientecol] [nvarchar](45) NULL,
 CONSTRAINT [PK_paciente_idPaciente] PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC,
	[Persona_Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[persona]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[persona](
	[Persona_id] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [int] NOT NULL,
	[Nombre] [nchar](30) NOT NULL,
	[Apellido] [nchar](45) NOT NULL,
	[Edad] [int] NOT NULL,
	[Sexo] [nvarchar](1) NOT NULL,
	[Estado_Civil] [nvarchar](45) NOT NULL,
	[E-Mail] [nvarchar](45) NOT NULL,
	[Celular] [nvarchar](45) NOT NULL,
	[TelFijo] [nvarchar](45) NULL,
	[Fecha_Nacimiento] [date] NOT NULL,
	[Nacionalidad] [nvarchar](45) NOT NULL,
	[Prov_Nacimiento] [nvarchar](45) NOT NULL,
 CONSTRAINT [PK_persona_Persona_id] PRIMARY KEY CLUSTERED 
(
	[Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [mydb].[provincia]    Script Date: 25/11/2018 21:39:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [mydb].[provincia](
	[Persona_id] [int] IDENTITY(1,1) NOT NULL,
	[Prov_Residencia] [nvarchar](45) NOT NULL,
	[CodigoPostal] [nvarchar](45) NOT NULL,
 CONSTRAINT [PK_provincia_Persona_id] PRIMARY KEY CLUSTERED 
(
	[Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [mydb].[persona] ON 
GO
INSERT [mydb].[persona] ([Persona_id], [DNI], [Nombre], [Apellido], [Edad], [Sexo], [Estado_Civil], [E-Mail], [Celular], [TelFijo], [Fecha_Nacimiento], [Nacionalidad], [Prov_Nacimiento]) VALUES (1, 40223445, N'pepe                          ', N'epep                                         ', 12, N'm', N'ds', N'asdfgh', N'1234567', N'123456', CAST(N'2000-12-12' AS Date), N'argentina', N'argentinopolis')
GO
INSERT [mydb].[persona] ([Persona_id], [DNI], [Nombre], [Apellido], [Edad], [Sexo], [Estado_Civil], [E-Mail], [Celular], [TelFijo], [Fecha_Nacimiento], [Nacionalidad], [Prov_Nacimiento]) VALUES (2, 123456, N'aPepea                        ', N'asdasd                                       ', 33, N'f', N'asdasd', N'asdasd', N'1234566666', N'1111111', CAST(N'1999-10-09' AS Date), N'Brasil', N'saupavlo')
GO
INSERT [mydb].[persona] ([Persona_id], [DNI], [Nombre], [Apellido], [Edad], [Sexo], [Estado_Civil], [E-Mail], [Celular], [TelFijo], [Fecha_Nacimiento], [Nacionalidad], [Prov_Nacimiento]) VALUES (3, 987654321, N'Unapepersona                  ', N'PP                                           ', 22, N'F', N'Algo', N'Email@Email', N'123456', N'654321', CAST(N'1997-12-22' AS Date), N'UnGarron', N'Florida')
GO
INSERT [mydb].[persona] ([Persona_id], [DNI], [Nombre], [Apellido], [Edad], [Sexo], [Estado_Civil], [E-Mail], [Celular], [TelFijo], [Fecha_Nacimiento], [Nacionalidad], [Prov_Nacimiento]) VALUES (4, 987654321, N'aa                            ', N'PP                                           ', 22, N'F', N'Algo', N'Email@Email', N'123456', N'654321', CAST(N'1997-12-22' AS Date), N'UnGarron', N'Florida')
GO
INSERT [mydb].[persona] ([Persona_id], [DNI], [Nombre], [Apellido], [Edad], [Sexo], [Estado_Civil], [E-Mail], [Celular], [TelFijo], [Fecha_Nacimiento], [Nacionalidad], [Prov_Nacimiento]) VALUES (5, 11111, N'aa                            ', N'PP                                           ', 22, N'F', N'Algo', N'Email@Email', N'123456', N'654321', CAST(N'1997-12-22' AS Date), N'UnGarron', N'Florida')
GO
SET IDENTITY_INSERT [mydb].[persona] OFF
GO
/****** Object:  Index [fk_afiliacion_ObraSocial1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_afiliacion_ObraSocial1_idx] ON [mydb].[afiliacion]
(
	[ObraSocial_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_afiliacion_ObraSocial1_idx] ON [mydb].[afiliacion] DISABLE
GO
/****** Object:  Index [fk_afiliacion_Persona1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_afiliacion_Persona1_idx] ON [mydb].[afiliacion]
(
	[Persona_Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_afiliacion_Persona1_idx] ON [mydb].[afiliacion] DISABLE
GO
/****** Object:  Index [fk_Antecedentes_Familiares_Paciente1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_Antecedentes_Familiares_Paciente1_idx] ON [mydb].[antecedentes_familiares]
(
	[Paciente_idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_Antecedentes_Familiares_Paciente1_idx] ON [mydb].[antecedentes_familiares] DISABLE
GO
/****** Object:  Index [fk_Antecedentes_Patologicos_Paciente1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_Antecedentes_Patologicos_Paciente1_idx] ON [mydb].[antecedentes_patologicos]
(
	[Paciente_idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_Antecedentes_Patologicos_Paciente1_idx] ON [mydb].[antecedentes_patologicos] DISABLE
GO
/****** Object:  Index [fk_Antecedentes Psicologicos_Paciente1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_Antecedentes Psicologicos_Paciente1_idx] ON [mydb].[antecedentes_psicologicos]
(
	[Paciente_idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_Antecedentes Psicologicos_Paciente1_idx] ON [mydb].[antecedentes_psicologicos] DISABLE
GO
/****** Object:  Index [fk_Barrio_Ciudad1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_Barrio_Ciudad1_idx] ON [mydb].[barrio]
(
	[Ciudad_Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_Barrio_Ciudad1_idx] ON [mydb].[barrio] DISABLE
GO
/****** Object:  Index [fk_Barrio_Persona1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_Barrio_Persona1_idx] ON [mydb].[barrio]
(
	[Persona_Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_Barrio_Persona1_idx] ON [mydb].[barrio] DISABLE
GO
/****** Object:  Index [fk_Calle_Barrio1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_Calle_Barrio1_idx] ON [mydb].[calle]
(
	[Barrio_Persona_id] ASC,
	[Barrio_Persona_Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_Calle_Barrio1_idx] ON [mydb].[calle] DISABLE
GO
/****** Object:  Index [fk_Calle_Persona1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_Calle_Persona1_idx] ON [mydb].[calle]
(
	[Persona_Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_Calle_Persona1_idx] ON [mydb].[calle] DISABLE
GO
/****** Object:  Index [fk_Ciudad_Provincia1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_Ciudad_Provincia1_idx] ON [mydb].[ciudad]
(
	[Provincia_Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_Ciudad_Provincia1_idx] ON [mydb].[ciudad] DISABLE
GO
/****** Object:  Index [fk_Doctor_Persona1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_Doctor_Persona1_idx] ON [mydb].[doctor]
(
	[Persona_Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_Doctor_Persona1_idx] ON [mydb].[doctor] DISABLE
GO
/****** Object:  Index [fk_Emergencia_Persona1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_Emergencia_Persona1_idx] ON [mydb].[emergencia]
(
	[Persona_Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_Emergencia_Persona1_idx] ON [mydb].[emergencia] DISABLE
GO
/****** Object:  Index [fk_Habitos_Toxicos_Paciente1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_Habitos_Toxicos_Paciente1_idx] ON [mydb].[habitos_toxicos]
(
	[Paciente_idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_Habitos_Toxicos_Paciente1_idx] ON [mydb].[habitos_toxicos] DISABLE
GO
/****** Object:  Index [fk_Institucion_has_Doctor_Doctor1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_Institucion_has_Doctor_Doctor1_idx] ON [mydb].[institucion_has_doctor]
(
	[Doctor_Doctor_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_Institucion_has_Doctor_Doctor1_idx] ON [mydb].[institucion_has_doctor] DISABLE
GO
/****** Object:  Index [fk_Institucion_has_Doctor_Institucion1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_Institucion_has_Doctor_Institucion1_idx] ON [mydb].[institucion_has_doctor]
(
	[Institucion_Doctor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_Institucion_has_Doctor_Institucion1_idx] ON [mydb].[institucion_has_doctor] DISABLE
GO
/****** Object:  Index [fk_Paciente_Persona1_idx]    Script Date: 25/11/2018 21:39:37 ******/
CREATE NONCLUSTERED INDEX [fk_Paciente_Persona1_idx] ON [mydb].[paciente]
(
	[Persona_Persona_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER INDEX [fk_Paciente_Persona1_idx] ON [mydb].[paciente] DISABLE
GO
ALTER TABLE [mydb].[afiliacion] ADD  DEFAULT (NULL) FOR [Fecha_Vencimiento]
GO
ALTER TABLE [mydb].[afiliacion] ADD  DEFAULT (NULL) FOR [Num_Afiliado]
GO
ALTER TABLE [mydb].[domicilio] ADD  DEFAULT (NULL) FOR [Numero]
GO
ALTER TABLE [mydb].[institucion] ADD  DEFAULT (NULL) FOR [Institucion]
GO
ALTER TABLE [mydb].[institucion] ADD  DEFAULT (NULL) FOR [Calle_Institucion]
GO
ALTER TABLE [mydb].[institucion] ADD  DEFAULT (NULL) FOR [Num_calle]
GO
ALTER TABLE [mydb].[obrasocial] ADD  DEFAULT (NULL) FOR [telefono]
GO
ALTER TABLE [mydb].[paciente] ADD  DEFAULT (NULL) FOR [Vacunas_faltantes]
GO
ALTER TABLE [mydb].[paciente] ADD  DEFAULT (NULL) FOR [Pacientecol]
GO
ALTER TABLE [mydb].[persona] ADD  DEFAULT (NULL) FOR [TelFijo]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.afiliacion' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'afiliacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.antecedentes_familiares' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'antecedentes_familiares'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.antecedentes_patologicos' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'antecedentes_patologicos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.antecedentes_psicologicos' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'antecedentes_psicologicos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.barrio' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'barrio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.calle' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'calle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.ciudad' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'ciudad'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.doctor' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'doctor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.domicilio' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'domicilio'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.emergencia' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'emergencia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.habitos_toxicos' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'habitos_toxicos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.institucion' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'institucion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.institucion_has_doctor' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'institucion_has_doctor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.obrasocial' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'obrasocial'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.paciente' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'paciente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.persona' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'persona'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'mydb.provincia' , @level0type=N'SCHEMA',@level0name=N'mydb', @level1type=N'TABLE',@level1name=N'provincia'
GO
USE [master]
GO
ALTER DATABASE [HistoriaClinica] SET  READ_WRITE 
GO
