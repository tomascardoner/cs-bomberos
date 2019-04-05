USE [CSBomberos]
GO
/****** Object:  Table [dbo].[Alarma]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Alarma](
	[IDAlarma] [smallint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[FechaTipo] [char](2) NOT NULL,
	[Fecha] [date] NULL,
	[AvisoDias] [smallint] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Alarma] PRIMARY KEY CLUSTERED 
(
	[IDAlarma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Area]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Area](
	[IDArea] [smallint] NOT NULL,
	[IDCuartel] [tinyint] NOT NULL,
	[Codigo] [char](5) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Area] PRIMARY KEY CLUSTERED 
(
	[IDArea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Automotor]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Automotor](
	[IDAutomotor] [smallint] NOT NULL,
	[Numero] [smallint] NOT NULL,
	[Marca] [varchar](50) NOT NULL,
	[Modelo] [varchar](50) NOT NULL,
	[MarcaModelo]  AS (([Marca]+' ')+[Modelo]),
	[NumeroMarcaModelo]  AS ((((CONVERT([varchar](5),[Numero])+' - ')+[Marca])+' ')+[Modelo]),
	[EsImportado] [bit] NULL,
	[Anio] [smallint] NOT NULL,
	[NumeroMotor] [varchar](20) NULL,
	[NumeroChasis] [varchar](20) NULL,
	[Dominio] [varchar](7) NULL,
	[IDAutomotorTipo] [tinyint] NOT NULL,
	[IDAutomotorUso] [tinyint] NOT NULL,
	[IDCombustibleTipo] [tinyint] NULL,
	[FechaAdquisicion] [date] NULL,
	[KilometrajeInicial] [int] NULL,
	[CapacidadAguaLitros] [int] NULL,
	[IDCuartel] [tinyint] NOT NULL,
	[EsPropio] [bit] NOT NULL,
	[VerificacionVencimiento] [date] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDAutomotorBajaMotivo] [tinyint] NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Automotor] PRIMARY KEY CLUSTERED 
(
	[IDAutomotor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AutomotorBajaMotivo]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AutomotorBajaMotivo](
	[IDAutomotorBajaMotivo] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__AutomotorBajaMotivo] PRIMARY KEY CLUSTERED 
(
	[IDAutomotorBajaMotivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AutomotorTipo]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AutomotorTipo](
	[IDAutomotorTipo] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__AutomotorTipo] PRIMARY KEY CLUSTERED 
(
	[IDAutomotorTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AutomotorUso]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AutomotorUso](
	[IDAutomotorUso] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__AutomotorUso] PRIMARY KEY CLUSTERED 
(
	[IDAutomotorUso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CalificacionConcepto]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CalificacionConcepto](
	[IDCalificacionConcepto] [tinyint] NOT NULL,
	[Abreviatura] [char](2) NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](max) NULL,
	[Orden] [tinyint] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__CalificacionConcepto] PRIMARY KEY CLUSTERED 
(
	[IDCalificacionConcepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CapacitacionNivel]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CapacitacionNivel](
	[IDCapacitacionNivel] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__CapacitacionNivel] PRIMARY KEY CLUSTERED 
(
	[IDCapacitacionNivel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CapacitacionTipo]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CapacitacionTipo](
	[IDCapacitacionTipo] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__CapacitacionTipo] PRIMARY KEY CLUSTERED 
(
	[IDCapacitacionTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cargo](
	[IDCargo] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Orden] [tinyint] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Cargo] PRIMARY KEY CLUSTERED 
(
	[IDCargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CargoJerarquia]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CargoJerarquia](
	[IDCargo] [tinyint] NOT NULL,
	[IDJerarquia] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Orden] [tinyint] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__CargoJerarquia] PRIMARY KEY CLUSTERED 
(
	[IDCargo] ASC,
	[IDJerarquia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CombustibleTipo]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CombustibleTipo](
	[IDCombustibleTipo] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__CombustibleTipo] PRIMARY KEY CLUSTERED 
(
	[IDCombustibleTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cuartel]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cuartel](
	[IDCuartel] [tinyint] NOT NULL,
	[Codigo] [char](3) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[DomicilioCalle1] [varchar](100) NULL,
	[DomicilioNumero] [varchar](10) NULL,
	[DomicilioPiso] [varchar](10) NULL,
	[DomicilioDepartamento] [varchar](10) NULL,
	[DomicilioCalle2] [varchar](50) NULL,
	[DomicilioCalle3] [varchar](50) NULL,
	[DomicilioCodigoPostal] [varchar](8) NULL,
	[DomicilioIDProvincia] [tinyint] NULL,
	[DomicilioIDLocalidad] [smallint] NULL,
	[Telefono] [varchar](50) NULL,
	[Celular] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Cuartel] PRIMARY KEY CLUSTERED 
(
	[IDCuartel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Curso](
	[IDCurso] [smallint] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Curso] PRIMARY KEY CLUSTERED 
(
	[IDCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DocumentacionTipo]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DocumentacionTipo](
	[IDDocumentacionTipo] [tinyint] NOT NULL,
	[EntidadTipo] [char](1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [datetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [datetime] NOT NULL,
 CONSTRAINT [PK__DocumentacionTipo] PRIMARY KEY CLUSTERED 
(
	[IDDocumentacionTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DocumentoTipo]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DocumentoTipo](
	[IDDocumentoTipo] [tinyint] NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[VerificaModulo11] [bit] NOT NULL,
	[EsActivo] [bit] NOT NULL,
 CONSTRAINT [PK__DocumentoTipo] PRIMARY KEY CLUSTERED 
(
	[IDDocumentoTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Elemento]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Elemento](
	[IDElemento] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[IDRubro] [tinyint] NULL,
	[IDSubRubro] [smallint] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Elemento] PRIMARY KEY CLUSTERED 
(
	[IDElemento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inventario](
	[IDInventario] [int] NOT NULL,
	[IDArea] [smallint] NOT NULL,
	[Codigo] [char](5) NULL,
	[Cantidad] [smallint] NULL,
	[IDElemento] [int] NOT NULL,
	[DescripcionPropia] [varchar](100) NULL,
	[IDModoAdquisicion] [tinyint] NULL,
	[IDUbicacion] [smallint] NULL,
	[IDSubUbicacion] [smallint] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[FechaBaja] [date] NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Inventario] PRIMARY KEY CLUSTERED 
(
	[IDInventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LicenciaCausa]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LicenciaCausa](
	[IDLicenciaCausa] [tinyint] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[NombreLegal] [varchar](200) NULL,
	[CantidadDias] [tinyint] NULL,
	[CantidadDiasMaximoAnual] [tinyint] NULL,
	[CantidadVecesMaximoAnual] [tinyint] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__LicenciaCausa] PRIMARY KEY CLUSTERED 
(
	[IDLicenciaCausa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LicenciaConducirCategoria]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LicenciaConducirCategoria](
	[IDLicenciaConducirCategoria] [tinyint] NOT NULL,
	[Codigo] [varchar](10) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__LicenciaConducirCategoria] PRIMARY KEY CLUSTERED 
(
	[IDLicenciaConducirCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Localidad](
	[IDProvincia] [tinyint] NOT NULL,
	[IDLocalidad] [smallint] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[CodigoPostal] [char](4) NULL,
 CONSTRAINT [PK__Localidad] PRIMARY KEY CLUSTERED 
(
	[IDProvincia] ASC,
	[IDLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Log]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Log](
	[IDLog] [int] NOT NULL,
	[IDUsuario] [smallint] NOT NULL,
	[Accion] [char](4) NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
 CONSTRAINT [PK__Log] PRIMARY KEY CLUSTERED 
(
	[IDLog] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ModoAdquisicion]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ModoAdquisicion](
	[IDModoAdquisicion] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__ModoAdquisicion] PRIMARY KEY CLUSTERED 
(
	[IDModoAdquisicion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NivelEstudio]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NivelEstudio](
	[IDNivelEstudio] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[IncluyeSecundario] [bit] NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__NivelEstudio] PRIMARY KEY CLUSTERED 
(
	[IDNivelEstudio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Parametro]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Parametro](
	[IDParametro] [char](100) NOT NULL,
	[Texto] [varchar](max) NULL,
	[NumeroEntero] [int] NULL,
	[NumeroDecimal] [decimal](18, 9) NULL,
	[Moneda] [money] NULL,
	[FechaHora] [smalldatetime] NULL,
	[SiNo] [bit] NULL,
	[Notas] [varchar](max) NULL,
 CONSTRAINT [PK__Parametro] PRIMARY KEY CLUSTERED 
(
	[IDParametro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Parentesco]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Parentesco](
	[IDParentesco] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Orden] [tinyint] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Parentesco] PRIMARY KEY CLUSTERED 
(
	[IDParentesco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PenaAplicacion]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PenaAplicacion](
	[IDPenaAplicacion] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__PenaAplicacion] PRIMARY KEY CLUSTERED 
(
	[IDPenaAplicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Persona](
	[IDPersona] [int] NOT NULL,
	[Foto] [image] NULL,
	[MatriculaNumero] [char](6) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[ApellidoNombre]  AS ([Apellido]+case isnull([Nombre],'') when '' then '' else ', '+[Nombre] end),
	[IDDocumentoTipo] [tinyint] NULL,
	[DocumentoNumero] [varchar](12) NULL,
	[LicenciaConducirNumero] [varchar](12) NULL,
	[LicenciaConducirVencimiento] [date] NULL,
	[FechaNacimiento] [date] NULL,
	[Genero] [char](1) NOT NULL,
	[GrupoSanguineo] [char](2) NULL,
	[FactorRH] [char](1) NULL,
	[Altura] [decimal](3, 2) NULL,
	[Peso] [tinyint] NULL,
	[IOMATiene] [char](1) NULL,
	[IOMANumeroAfiliado] [varchar](13) NULL,
	[IDNivelEstudio] [tinyint] NULL,
	[Profesion] [varchar](50) NULL,
	[Nacionalidad] [varchar](50) NULL,
	[IDCuartel] [tinyint] NOT NULL,
	[DomicilioParticularCalle1] [varchar](100) NULL,
	[DomicilioParticularNumero] [varchar](10) NULL,
	[DomicilioParticularPiso] [varchar](10) NULL,
	[DomicilioParticularDepartamento] [varchar](10) NULL,
	[DomicilioParticularCalle2] [varchar](50) NULL,
	[DomicilioParticularCalle3] [varchar](50) NULL,
	[DomicilioParticularCodigoPostal] [varchar](8) NULL,
	[DomicilioParticularIDProvincia] [tinyint] NULL,
	[DomicilioParticularIDLocalidad] [smallint] NULL,
	[TelefonoParticular] [varchar](50) NULL,
	[CelularParticular] [varchar](50) NULL,
	[EmailParticular] [varchar](50) NULL,
	[DomicilioLaboralCalle1] [varchar](100) NULL,
	[DomicilioLaboralNumero] [varchar](10) NULL,
	[DomicilioLaboralPiso] [varchar](10) NULL,
	[DomicilioLaboralDepartamento] [varchar](10) NULL,
	[DomicilioLaboralCalle2] [varchar](50) NULL,
	[DomicilioLaboralCalle3] [varchar](50) NULL,
	[DomicilioLaboralCodigoPostal] [varchar](8) NULL,
	[DomicilioLaboralIDProvincia] [tinyint] NULL,
	[DomicilioLaboralIDLocalidad] [smallint] NULL,
	[TelefonoLaboral] [varchar](50) NULL,
	[CelularLaboral] [varchar](50) NULL,
	[EmailLaboral] [varchar](50) NULL,
	[Notas] [varchar](50) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Persona] PRIMARY KEY CLUSTERED 
(
	[IDPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonaAccidente]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonaAccidente](
	[IDPersona] [int] NOT NULL,
	[IDAccidente] [smallint] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Diagnostico] [varchar](500) NOT NULL,
	[LibroNumero] [varchar](10) NULL,
	[FolioNumero] [varchar](10) NULL,
	[ActaNumero] [varchar](10) NULL,
	[FechaAlta] [date] NULL,
	[Capacidad] [varchar](500) NULL,
	[DisminucionFisica] [varchar](500) NULL,
	[Notas] [varchar](max) NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__PersonaAccidente] PRIMARY KEY CLUSTERED 
(
	[IDPersona] ASC,
	[IDAccidente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonaAltaBaja]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonaAltaBaja](
	[IDPersona] [int] NOT NULL,
	[IDAltaBaja] [tinyint] NOT NULL,
	[AltaFecha] [date] NOT NULL,
	[AltaLibroNumero] [varchar](10) NULL,
	[AltaFolioNumero] [varchar](10) NULL,
	[AltaActaNumero] [varchar](10) NULL,
	[BajaFecha] [date] NULL,
	[BajaLibroNumero] [varchar](10) NULL,
	[BajaFolioNumero] [varchar](10) NULL,
	[BajaActaNumero] [varchar](10) NULL,
	[IDPersonaBajaMotivo] [tinyint] NULL,
	[BajaUnidadDestino] [varchar](50) NULL,
	[Notas] [varchar](max) NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__PersonaAltaBaja] PRIMARY KEY CLUSTERED 
(
	[IDPersona] ASC,
	[IDAltaBaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonaAscenso]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonaAscenso](
	[IDPersona] [int] NOT NULL,
	[IDAscenso] [tinyint] NOT NULL,
	[Fecha] [date] NOT NULL,
	[IDCargo] [tinyint] NOT NULL,
	[IDJerarquia] [tinyint] NOT NULL,
	[LibroNumero] [varchar](10) NULL,
	[FolioNumero] [varchar](10) NULL,
	[ActaNumero] [varchar](10) NULL,
	[ResolucionNumero] [varchar](15) NULL,
	[Notas] [varchar](max) NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__PersonaAscenso] PRIMARY KEY CLUSTERED 
(
	[IDPersona] ASC,
	[IDAscenso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonaBajaMotivo]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonaBajaMotivo](
	[IDPersonaBajaMotivo] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[EspecificaDestino] [bit] NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__PersonaBajaMotivo] PRIMARY KEY CLUSTERED 
(
	[IDPersonaBajaMotivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonaCalificacion]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonaCalificacion](
	[IDPersona] [int] NOT NULL,
	[Anio] [smallint] NOT NULL,
	[InstanciaNumero] [tinyint] NOT NULL,
	[IDCalificacionConcepto] [tinyint] NOT NULL,
	[Calificacion] [decimal](4, 2) NOT NULL,
	[Notas] [varchar](max) NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__PersonaCalificacion] PRIMARY KEY CLUSTERED 
(
	[IDPersona] ASC,
	[Anio] ASC,
	[InstanciaNumero] ASC,
	[IDCalificacionConcepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonaCapacitacion]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonaCapacitacion](
	[IDPersona] [int] NOT NULL,
	[IDCapacitacion] [smallint] NOT NULL,
	[Fecha] [date] NOT NULL,
	[IDCurso] [smallint] NOT NULL,
	[IDProvincia] [tinyint] NULL,
	[IDLocalidad] [smallint] NULL,
	[IDCapacitacionNivel] [tinyint] NULL,
	[CapacitacionNivelOtro] [varchar](200) NULL,
	[IDCapacitacionTipo] [tinyint] NULL,
	[CapacitacionTipoOtro] [varchar](200) NULL,
	[CantidadHoras] [smallint] NULL,
	[CantidadDias] [smallint] NULL,
	[Notas] [varchar](max) NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__PersonaCapacitacion] PRIMARY KEY CLUSTERED 
(
	[IDPersona] ASC,
	[IDCapacitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonaExamen]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonaExamen](
	[IDPersona] [int] NOT NULL,
	[Anio] [smallint] NOT NULL,
	[InstanciaNumero] [tinyint] NOT NULL,
	[Calificacion] [decimal](4, 2) NOT NULL,
	[Notas] [varchar](max) NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__PersonaExamen] PRIMARY KEY CLUSTERED 
(
	[IDPersona] ASC,
	[Anio] ASC,
	[InstanciaNumero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonaFamiliar]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonaFamiliar](
	[IDPersona] [int] NOT NULL,
	[IDFamiliar] [tinyint] NOT NULL,
	[IDParentesco] [tinyint] NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[ApellidoNombre]  AS ([Apellido]+case isnull([Nombre],'') when '' then '' else ', '+[Nombre] end),
	[IDDocumentoTipo] [tinyint] NULL,
	[DocumentoNumero] [varchar](12) NULL,
	[FechaNacimiento] [date] NULL,
	[Genero] [char](1) NOT NULL,
	[GrupoSanguineo] [char](2) NULL,
	[FactorRH] [char](1) NULL,
	[IOMATiene] [char](1) NULL,
	[IOMANumeroAfiliado] [varchar](13) NULL,
	[IOMAACargo] [bit] NOT NULL,
	[ACargo] [bit] NOT NULL,
	[Vive] [bit] NOT NULL CONSTRAINT [DF_PersonaFamiliar_Vive]  DEFAULT ((1)),
	[DomicilioCalle1] [varchar](100) NULL,
	[DomicilioNumero] [varchar](10) NULL,
	[DomicilioPiso] [varchar](10) NULL,
	[DomicilioDepartamento] [varchar](10) NULL,
	[DomicilioCalle2] [varchar](50) NULL,
	[DomicilioCalle3] [varchar](50) NULL,
	[DomicilioCodigoPostal] [varchar](8) NULL,
	[DomicilioIDProvincia] [tinyint] NULL,
	[DomicilioIDLocalidad] [smallint] NULL,
	[Telefono] [varchar](50) NULL,
	[Celular] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__PersonaFamiliar] PRIMARY KEY CLUSTERED 
(
	[IDPersona] ASC,
	[IDFamiliar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonaLicencia]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonaLicencia](
	[IDPersona] [int] NOT NULL,
	[IDLicencia] [smallint] NOT NULL,
	[Fecha] [date] NOT NULL,
	[IDLicenciaCausa] [tinyint] NOT NULL,
	[FechaDesde] [date] NOT NULL,
	[FechaHasta] [date] NOT NULL,
	[FechaInterrupcion] [date] NULL,
	[Notas] [varchar](max) NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__PersonaLicencia] PRIMARY KEY CLUSTERED 
(
	[IDPersona] ASC,
	[IDLicencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonaLicenciaConducirCategoria]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonaLicenciaConducirCategoria](
	[IDPersona] [int] NOT NULL,
	[IDLicenciaConducirCategoria] [tinyint] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__PersonaLicenciaConducirCategoria] PRIMARY KEY CLUSTERED 
(
	[IDPersona] ASC,
	[IDLicenciaConducirCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonaSancion]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonaSancion](
	[IDPersona] [int] NOT NULL,
	[IDSancion] [smallint] NOT NULL,
	[SolicitudIDPersona] [int] NOT NULL,
	[SolicitudMotivo] [varchar](max) NOT NULL,
	[SolicitudFecha] [date] NOT NULL,
	[EncuadreTexto] [varchar](max) NULL,
	[EncuadreFecha] [date] NULL,
	[ResolucionIDSancionTipo] [tinyint] NULL,
	[ResolucionFecha] [date] NULL,
	[NotificacionFecha] [date] NULL,
	[Notas] [varchar](max) NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__PersonaSancion] PRIMARY KEY CLUSTERED 
(
	[IDPersona] ASC,
	[IDSancion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provincia](
	[IDProvincia] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Provincia] PRIMARY KEY CLUSTERED 
(
	[IDProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reporte]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reporte](
	[IDReporte] [smallint] NOT NULL,
	[IDReporteGrupo] [tinyint] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Archivo] [varchar](100) NOT NULL,
	[MostrarEnVisor] [bit] NOT NULL,
 CONSTRAINT [PK__Reporte] PRIMARY KEY CLUSTERED 
(
	[IDReporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ReporteGrupo]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ReporteGrupo](
	[IDReporteGrupo] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[EsActivo] [bit] NOT NULL,
 CONSTRAINT [PK__ReporteGrupo] PRIMARY KEY CLUSTERED 
(
	[IDReporteGrupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ReporteParametro]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ReporteParametro](
	[IDReporte] [smallint] NOT NULL,
	[IDParametro] [char](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Tipo] [char](4) NOT NULL,
	[Requerido] [bit] NOT NULL,
	[RequeridoLeyenda] [varchar](200) NULL,
	[ValorPredeterminadoTexto] [varchar](500) NULL,
	[ValorPredeterminadoNumeroEntero] [int] NULL,
	[ValorPredeterminadoNumeroDecimal] [decimal](18, 9) NULL,
	[ValorPredeterminadoMoneda] [money] NULL,
	[ValorPredeterminadoFechaHora] [smalldatetime] NULL,
	[ValorPredeterminadoSiNo] [bit] NULL,
	[Orden] [tinyint] NULL,
 CONSTRAINT [PK__ReporteParametro] PRIMARY KEY CLUSTERED 
(
	[IDReporte] ASC,
	[IDParametro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rubro]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rubro](
	[IDRubro] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Rubro] PRIMARY KEY CLUSTERED 
(
	[IDRubro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SancionTipo]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SancionTipo](
	[IDSancionTipo] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[CantidadDias] [smallint] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__SancionTipo] PRIMARY KEY CLUSTERED 
(
	[IDSancionTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SubRubro]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SubRubro](
	[IDSubRubro] [smallint] NOT NULL,
	[IDRubro] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__SubRubro] PRIMARY KEY CLUSTERED 
(
	[IDSubRubro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SubUbicacion]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SubUbicacion](
	[IDSubUbicacion] [smallint] NOT NULL,
	[IDUbicacion] [smallint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__SubUbicacion] PRIMARY KEY CLUSTERED 
(
	[IDSubUbicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ubicacion]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ubicacion](
	[IDUbicacion] [smallint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[IDCuartel] [tinyint] NOT NULL,
	[IDAutomotor] [smallint] NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Ubicacion] PRIMARY KEY CLUSTERED 
(
	[IDUbicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[IDUsuario] [smallint] NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Genero] [char](1) NOT NULL,
	[IDUsuarioGrupo] [tinyint] NOT NULL,
	[IDCuartel] [tinyint] NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__Usuario] PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsuarioGrupo]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UsuarioGrupo](
	[IDUsuarioGrupo] [tinyint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Notas] [varchar](max) NULL,
	[EsActivo] [bit] NOT NULL,
	[IDUsuarioCreacion] [smallint] NOT NULL,
	[FechaHoraCreacion] [smalldatetime] NOT NULL,
	[IDUsuarioModificacion] [smallint] NOT NULL,
	[FechaHoraModificacion] [smalldatetime] NOT NULL,
 CONSTRAINT [PK__UsuarioGrupo] PRIMARY KEY CLUSTERED 
(
	[IDUsuarioGrupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsuarioGrupoPermiso]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UsuarioGrupoPermiso](
	[IDUsuarioGrupo] [tinyint] NOT NULL,
	[IDPermiso] [char](100) NOT NULL,
 CONSTRAINT [PK__UsuarioGrupoPermiso] PRIMARY KEY CLUSTERED 
(
	[IDUsuarioGrupo] ASC,
	[IDPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsuarioParametro]    Script Date: 05/04/2019 19:21:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UsuarioParametro](
	[IDUsuario] [smallint] NOT NULL,
	[IDParametro] [char](100) NOT NULL,
	[Texto] [varchar](max) NULL,
	[NumeroEntero] [int] NULL,
	[NumeroDecimal] [decimal](18, 9) NULL,
	[Moneda] [money] NULL,
	[FechaHora] [smalldatetime] NULL,
	[SiNo] [bit] NULL,
	[Notas] [varchar](max) NULL,
 CONSTRAINT [PK__UsuarioParametro] PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC,
	[IDParametro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Alarma]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Alarma__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Alarma] CHECK CONSTRAINT [FK__Usuario__Alarma__Creacion]
GO
ALTER TABLE [dbo].[Alarma]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Alarma__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Alarma] CHECK CONSTRAINT [FK__Usuario__Alarma__Modificacion]
GO
ALTER TABLE [dbo].[Area]  WITH CHECK ADD  CONSTRAINT [FK__Cuartel__Area] FOREIGN KEY([IDCuartel])
REFERENCES [dbo].[Cuartel] ([IDCuartel])
GO
ALTER TABLE [dbo].[Area] CHECK CONSTRAINT [FK__Cuartel__Area]
GO
ALTER TABLE [dbo].[Area]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Area__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Area] CHECK CONSTRAINT [FK__Usuario__Area__Creacion]
GO
ALTER TABLE [dbo].[Area]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Area__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Area] CHECK CONSTRAINT [FK__Usuario__Area__Modificacion]
GO
ALTER TABLE [dbo].[Automotor]  WITH CHECK ADD  CONSTRAINT [FK__AutomotorBajaMotivo__Automotor] FOREIGN KEY([IDAutomotorBajaMotivo])
REFERENCES [dbo].[AutomotorBajaMotivo] ([IDAutomotorBajaMotivo])
GO
ALTER TABLE [dbo].[Automotor] CHECK CONSTRAINT [FK__AutomotorBajaMotivo__Automotor]
GO
ALTER TABLE [dbo].[Automotor]  WITH CHECK ADD  CONSTRAINT [FK__AutomotorTipo__Automotor] FOREIGN KEY([IDAutomotorTipo])
REFERENCES [dbo].[AutomotorTipo] ([IDAutomotorTipo])
GO
ALTER TABLE [dbo].[Automotor] CHECK CONSTRAINT [FK__AutomotorTipo__Automotor]
GO
ALTER TABLE [dbo].[Automotor]  WITH CHECK ADD  CONSTRAINT [FK__AutomotorUso__Automotor] FOREIGN KEY([IDAutomotorUso])
REFERENCES [dbo].[AutomotorUso] ([IDAutomotorUso])
GO
ALTER TABLE [dbo].[Automotor] CHECK CONSTRAINT [FK__AutomotorUso__Automotor]
GO
ALTER TABLE [dbo].[Automotor]  WITH CHECK ADD  CONSTRAINT [FK__CombustibleTipo__Automotor] FOREIGN KEY([IDCombustibleTipo])
REFERENCES [dbo].[CombustibleTipo] ([IDCombustibleTipo])
GO
ALTER TABLE [dbo].[Automotor] CHECK CONSTRAINT [FK__CombustibleTipo__Automotor]
GO
ALTER TABLE [dbo].[Automotor]  WITH CHECK ADD  CONSTRAINT [FK__Cuartel__Automotor] FOREIGN KEY([IDCuartel])
REFERENCES [dbo].[Cuartel] ([IDCuartel])
GO
ALTER TABLE [dbo].[Automotor] CHECK CONSTRAINT [FK__Cuartel__Automotor]
GO
ALTER TABLE [dbo].[Automotor]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Automotor__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Automotor] CHECK CONSTRAINT [FK__Usuario__Automotor__Creacion]
GO
ALTER TABLE [dbo].[Automotor]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Automotor__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Automotor] CHECK CONSTRAINT [FK__Usuario__Automotor__Modificacion]
GO
ALTER TABLE [dbo].[AutomotorBajaMotivo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__AutomotorBajaMotivo__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[AutomotorBajaMotivo] CHECK CONSTRAINT [FK__Usuario__AutomotorBajaMotivo__Creacion]
GO
ALTER TABLE [dbo].[AutomotorBajaMotivo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__AutomotorBajaMotivo__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[AutomotorBajaMotivo] CHECK CONSTRAINT [FK__Usuario__AutomotorBajaMotivo__Modificacion]
GO
ALTER TABLE [dbo].[AutomotorTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__AutomotorTipo__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[AutomotorTipo] CHECK CONSTRAINT [FK__Usuario__AutomotorTipo__Creacion]
GO
ALTER TABLE [dbo].[AutomotorTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__AutomotorTipo__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[AutomotorTipo] CHECK CONSTRAINT [FK__Usuario__AutomotorTipo__Modificacion]
GO
ALTER TABLE [dbo].[AutomotorUso]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__AutomotorUso__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[AutomotorUso] CHECK CONSTRAINT [FK__Usuario__AutomotorUso__Creacion]
GO
ALTER TABLE [dbo].[AutomotorUso]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__AutomotorUso__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[AutomotorUso] CHECK CONSTRAINT [FK__Usuario__AutomotorUso__Modificacion]
GO
ALTER TABLE [dbo].[CalificacionConcepto]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__CalificacionConcepto__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[CalificacionConcepto] CHECK CONSTRAINT [FK__Usuario__CalificacionConcepto__Creacion]
GO
ALTER TABLE [dbo].[CalificacionConcepto]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__CalificacionConcepto__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[CalificacionConcepto] CHECK CONSTRAINT [FK__Usuario__CalificacionConcepto__Modificacion]
GO
ALTER TABLE [dbo].[CapacitacionNivel]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__CapacitacionNivel__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[CapacitacionNivel] CHECK CONSTRAINT [FK__Usuario__CapacitacionNivel__Creacion]
GO
ALTER TABLE [dbo].[CapacitacionNivel]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__CapacitacionNivel__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[CapacitacionNivel] CHECK CONSTRAINT [FK__Usuario__CapacitacionNivel__Modificacion]
GO
ALTER TABLE [dbo].[CapacitacionTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__CapacitacionTipo__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[CapacitacionTipo] CHECK CONSTRAINT [FK__Usuario__CapacitacionTipo__Creacion]
GO
ALTER TABLE [dbo].[CapacitacionTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__CapacitacionTipo__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[CapacitacionTipo] CHECK CONSTRAINT [FK__Usuario__CapacitacionTipo__Modificacion]
GO
ALTER TABLE [dbo].[Cargo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Cargo__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Cargo] CHECK CONSTRAINT [FK__Usuario__Cargo__Creacion]
GO
ALTER TABLE [dbo].[Cargo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Cargo__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Cargo] CHECK CONSTRAINT [FK__Usuario__Cargo__Modificacion]
GO
ALTER TABLE [dbo].[CargoJerarquia]  WITH CHECK ADD  CONSTRAINT [FK__Cargo__CargoJerarquia] FOREIGN KEY([IDCargo])
REFERENCES [dbo].[Cargo] ([IDCargo])
GO
ALTER TABLE [dbo].[CargoJerarquia] CHECK CONSTRAINT [FK__Cargo__CargoJerarquia]
GO
ALTER TABLE [dbo].[CargoJerarquia]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__CargoJerarquia__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[CargoJerarquia] CHECK CONSTRAINT [FK__Usuario__CargoJerarquia__Creacion]
GO
ALTER TABLE [dbo].[CargoJerarquia]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__CargoJerarquia__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[CargoJerarquia] CHECK CONSTRAINT [FK__Usuario__CargoJerarquia__Modificacion]
GO
ALTER TABLE [dbo].[CombustibleTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__CombustibleTipo__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[CombustibleTipo] CHECK CONSTRAINT [FK__Usuario__CombustibleTipo__Creacion]
GO
ALTER TABLE [dbo].[CombustibleTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__CombustibleTipo__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[CombustibleTipo] CHECK CONSTRAINT [FK__Usuario__CombustibleTipo__Modificacion]
GO
ALTER TABLE [dbo].[Cuartel]  WITH CHECK ADD  CONSTRAINT [FK__Localidad__Cuartel] FOREIGN KEY([DomicilioIDProvincia], [DomicilioIDLocalidad])
REFERENCES [dbo].[Localidad] ([IDProvincia], [IDLocalidad])
GO
ALTER TABLE [dbo].[Cuartel] CHECK CONSTRAINT [FK__Localidad__Cuartel]
GO
ALTER TABLE [dbo].[Cuartel]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Cuartel__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Cuartel] CHECK CONSTRAINT [FK__Usuario__Cuartel__Creacion]
GO
ALTER TABLE [dbo].[Cuartel]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Cuartel__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Cuartel] CHECK CONSTRAINT [FK__Usuario__Cuartel__Modificacion]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Curso__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK__Usuario__Curso__Creacion]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Curso__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK__Usuario__Curso__Modificacion]
GO
ALTER TABLE [dbo].[DocumentacionTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__DocumentacionTipo__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[DocumentacionTipo] CHECK CONSTRAINT [FK__Usuario__DocumentacionTipo__Creacion]
GO
ALTER TABLE [dbo].[DocumentacionTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__DocumentacionTipo__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[DocumentacionTipo] CHECK CONSTRAINT [FK__Usuario__DocumentacionTipo__Modificacion]
GO
ALTER TABLE [dbo].[Elemento]  WITH CHECK ADD  CONSTRAINT [FK__Rubro__Elemento] FOREIGN KEY([IDRubro])
REFERENCES [dbo].[Rubro] ([IDRubro])
GO
ALTER TABLE [dbo].[Elemento] CHECK CONSTRAINT [FK__Rubro__Elemento]
GO
ALTER TABLE [dbo].[Elemento]  WITH CHECK ADD  CONSTRAINT [FK__SubRubro__Elemento] FOREIGN KEY([IDSubRubro])
REFERENCES [dbo].[SubRubro] ([IDSubRubro])
GO
ALTER TABLE [dbo].[Elemento] CHECK CONSTRAINT [FK__SubRubro__Elemento]
GO
ALTER TABLE [dbo].[Elemento]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Elemento__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Elemento] CHECK CONSTRAINT [FK__Usuario__Elemento__Creacion]
GO
ALTER TABLE [dbo].[Elemento]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Elemento__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Elemento] CHECK CONSTRAINT [FK__Usuario__Elemento__Modificacion]
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK__Area__Inventario] FOREIGN KEY([IDArea])
REFERENCES [dbo].[Area] ([IDArea])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK__Area__Inventario]
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK__Elemento__Inventario] FOREIGN KEY([IDElemento])
REFERENCES [dbo].[Elemento] ([IDElemento])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK__Elemento__Inventario]
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK__ModoAdquisicion__Inventario] FOREIGN KEY([IDModoAdquisicion])
REFERENCES [dbo].[ModoAdquisicion] ([IDModoAdquisicion])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK__ModoAdquisicion__Inventario]
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK__SubUbicacion__Inventario] FOREIGN KEY([IDSubUbicacion])
REFERENCES [dbo].[SubUbicacion] ([IDSubUbicacion])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK__SubUbicacion__Inventario]
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK__Ubicacion__Inventario] FOREIGN KEY([IDUbicacion])
REFERENCES [dbo].[Ubicacion] ([IDUbicacion])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK__Ubicacion__Inventario]
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Inventario__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK__Usuario__Inventario__Creacion]
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Inventario__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK__Usuario__Inventario__Modificacion]
GO
ALTER TABLE [dbo].[LicenciaCausa]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__LicenciaCausa__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[LicenciaCausa] CHECK CONSTRAINT [FK__Usuario__LicenciaCausa__Creacion]
GO
ALTER TABLE [dbo].[LicenciaCausa]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__LicenciaCausa__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[LicenciaCausa] CHECK CONSTRAINT [FK__Usuario__LicenciaCausa__Modificacion]
GO
ALTER TABLE [dbo].[LicenciaConducirCategoria]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__LicenciaConducirCategoria__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[LicenciaConducirCategoria] CHECK CONSTRAINT [FK__Usuario__LicenciaConducirCategoria__Creacion]
GO
ALTER TABLE [dbo].[LicenciaConducirCategoria]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__LicenciaConducirCategoria__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[LicenciaConducirCategoria] CHECK CONSTRAINT [FK__Usuario__LicenciaConducirCategoria__Modificacion]
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD  CONSTRAINT [FK__Provincia__Localidad] FOREIGN KEY([IDProvincia])
REFERENCES [dbo].[Provincia] ([IDProvincia])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Localidad] CHECK CONSTRAINT [FK__Provincia__Localidad]
GO
ALTER TABLE [dbo].[Log]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Log] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Log] CHECK CONSTRAINT [FK__Usuario__Log]
GO
ALTER TABLE [dbo].[ModoAdquisicion]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__ModoAdquisicion__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[ModoAdquisicion] CHECK CONSTRAINT [FK__Usuario__ModoAdquisicion__Creacion]
GO
ALTER TABLE [dbo].[ModoAdquisicion]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__ModoAdquisicion__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[ModoAdquisicion] CHECK CONSTRAINT [FK__Usuario__ModoAdquisicion__Modificacion]
GO
ALTER TABLE [dbo].[NivelEstudio]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__NivelEstudio__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[NivelEstudio] CHECK CONSTRAINT [FK__Usuario__NivelEstudio__Creacion]
GO
ALTER TABLE [dbo].[NivelEstudio]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__NivelEstudio__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[NivelEstudio] CHECK CONSTRAINT [FK__Usuario__NivelEstudio__Modificacion]
GO
ALTER TABLE [dbo].[Parentesco]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Parentesco__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Parentesco] CHECK CONSTRAINT [FK__Usuario__Parentesco__Creacion]
GO
ALTER TABLE [dbo].[Parentesco]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Parentesco__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Parentesco] CHECK CONSTRAINT [FK__Usuario__Parentesco__Modificacion]
GO
ALTER TABLE [dbo].[PenaAplicacion]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PenaAplicacion__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PenaAplicacion] CHECK CONSTRAINT [FK__Usuario__PenaAplicacion__Creacion]
GO
ALTER TABLE [dbo].[PenaAplicacion]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PenaAplicacion__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PenaAplicacion] CHECK CONSTRAINT [FK__Usuario__PenaAplicacion__Modificacion]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK__Cuartel__Persona] FOREIGN KEY([IDCuartel])
REFERENCES [dbo].[Cuartel] ([IDCuartel])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK__Cuartel__Persona]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK__DocumentoTipo__Persona] FOREIGN KEY([IDDocumentoTipo])
REFERENCES [dbo].[DocumentoTipo] ([IDDocumentoTipo])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK__DocumentoTipo__Persona]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK__NivelEstudio__Persona] FOREIGN KEY([IDNivelEstudio])
REFERENCES [dbo].[NivelEstudio] ([IDNivelEstudio])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK__NivelEstudio__Persona]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK__Persona__Localidad__Laboral] FOREIGN KEY([DomicilioLaboralIDProvincia], [DomicilioLaboralIDLocalidad])
REFERENCES [dbo].[Localidad] ([IDProvincia], [IDLocalidad])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK__Persona__Localidad__Laboral]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK__Persona__Localidad__Particular] FOREIGN KEY([DomicilioParticularIDProvincia], [DomicilioParticularIDLocalidad])
REFERENCES [dbo].[Localidad] ([IDProvincia], [IDLocalidad])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK__Persona__Localidad__Particular]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Persona__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK__Usuario__Persona__Creacion]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Persona__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK__Usuario__Persona__Modificacion]
GO
ALTER TABLE [dbo].[PersonaAccidente]  WITH CHECK ADD  CONSTRAINT [FK__Persona__PersonaAccidente] FOREIGN KEY([IDPersona])
REFERENCES [dbo].[Persona] ([IDPersona])
GO
ALTER TABLE [dbo].[PersonaAccidente] CHECK CONSTRAINT [FK__Persona__PersonaAccidente]
GO
ALTER TABLE [dbo].[PersonaAccidente]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaAccidente__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaAccidente] CHECK CONSTRAINT [FK__Usuario__PersonaAccidente__Creacion]
GO
ALTER TABLE [dbo].[PersonaAccidente]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaAccidente__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaAccidente] CHECK CONSTRAINT [FK__Usuario__PersonaAccidente__Modificacion]
GO
ALTER TABLE [dbo].[PersonaAltaBaja]  WITH CHECK ADD  CONSTRAINT [FK__Persona__PersonaAltaBaja] FOREIGN KEY([IDPersona])
REFERENCES [dbo].[Persona] ([IDPersona])
GO
ALTER TABLE [dbo].[PersonaAltaBaja] CHECK CONSTRAINT [FK__Persona__PersonaAltaBaja]
GO
ALTER TABLE [dbo].[PersonaAltaBaja]  WITH CHECK ADD  CONSTRAINT [FK__PersonaBajaMotivo__PersonaAltaBaja] FOREIGN KEY([IDPersonaBajaMotivo])
REFERENCES [dbo].[PersonaBajaMotivo] ([IDPersonaBajaMotivo])
GO
ALTER TABLE [dbo].[PersonaAltaBaja] CHECK CONSTRAINT [FK__PersonaBajaMotivo__PersonaAltaBaja]
GO
ALTER TABLE [dbo].[PersonaAltaBaja]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaAltaBaja__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaAltaBaja] CHECK CONSTRAINT [FK__Usuario__PersonaAltaBaja__Creacion]
GO
ALTER TABLE [dbo].[PersonaAltaBaja]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaAltaBaja__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaAltaBaja] CHECK CONSTRAINT [FK__Usuario__PersonaAltaBaja__Modificacion]
GO
ALTER TABLE [dbo].[PersonaAscenso]  WITH CHECK ADD  CONSTRAINT [FK__CargoJerarquia__PersonaAscenso] FOREIGN KEY([IDCargo], [IDJerarquia])
REFERENCES [dbo].[CargoJerarquia] ([IDCargo], [IDJerarquia])
GO
ALTER TABLE [dbo].[PersonaAscenso] CHECK CONSTRAINT [FK__CargoJerarquia__PersonaAscenso]
GO
ALTER TABLE [dbo].[PersonaAscenso]  WITH CHECK ADD  CONSTRAINT [FK__Persona__PersonaAscenso] FOREIGN KEY([IDPersona])
REFERENCES [dbo].[Persona] ([IDPersona])
GO
ALTER TABLE [dbo].[PersonaAscenso] CHECK CONSTRAINT [FK__Persona__PersonaAscenso]
GO
ALTER TABLE [dbo].[PersonaAscenso]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaAscenso__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaAscenso] CHECK CONSTRAINT [FK__Usuario__PersonaAscenso__Creacion]
GO
ALTER TABLE [dbo].[PersonaAscenso]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaAscenso__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaAscenso] CHECK CONSTRAINT [FK__Usuario__PersonaAscenso__Modificacion]
GO
ALTER TABLE [dbo].[PersonaBajaMotivo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaBajaMotivo__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaBajaMotivo] CHECK CONSTRAINT [FK__Usuario__PersonaBajaMotivo__Creacion]
GO
ALTER TABLE [dbo].[PersonaBajaMotivo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaBajaMotivo__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaBajaMotivo] CHECK CONSTRAINT [FK__Usuario__PersonaBajaMotivo__Modificacion]
GO
ALTER TABLE [dbo].[PersonaCalificacion]  WITH CHECK ADD  CONSTRAINT [FK__CalificacionConcepto__PersonaCalificacion] FOREIGN KEY([IDCalificacionConcepto])
REFERENCES [dbo].[CalificacionConcepto] ([IDCalificacionConcepto])
GO
ALTER TABLE [dbo].[PersonaCalificacion] CHECK CONSTRAINT [FK__CalificacionConcepto__PersonaCalificacion]
GO
ALTER TABLE [dbo].[PersonaCalificacion]  WITH CHECK ADD  CONSTRAINT [FK__Persona__PersonaCalificacion] FOREIGN KEY([IDPersona])
REFERENCES [dbo].[Persona] ([IDPersona])
GO
ALTER TABLE [dbo].[PersonaCalificacion] CHECK CONSTRAINT [FK__Persona__PersonaCalificacion]
GO
ALTER TABLE [dbo].[PersonaCalificacion]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaCalificacion__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaCalificacion] CHECK CONSTRAINT [FK__Usuario__PersonaCalificacion__Creacion]
GO
ALTER TABLE [dbo].[PersonaCalificacion]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaCalificacion__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaCalificacion] CHECK CONSTRAINT [FK__Usuario__PersonaCalificacion__Modificacion]
GO
ALTER TABLE [dbo].[PersonaCapacitacion]  WITH CHECK ADD  CONSTRAINT [FK__CapacitacionNivel__PersonaCapacitacion] FOREIGN KEY([IDCapacitacionNivel])
REFERENCES [dbo].[CapacitacionNivel] ([IDCapacitacionNivel])
GO
ALTER TABLE [dbo].[PersonaCapacitacion] CHECK CONSTRAINT [FK__CapacitacionNivel__PersonaCapacitacion]
GO
ALTER TABLE [dbo].[PersonaCapacitacion]  WITH CHECK ADD  CONSTRAINT [FK__CapacitacionTipo__PersonaCapacitacion] FOREIGN KEY([IDCapacitacionTipo])
REFERENCES [dbo].[CapacitacionTipo] ([IDCapacitacionTipo])
GO
ALTER TABLE [dbo].[PersonaCapacitacion] CHECK CONSTRAINT [FK__CapacitacionTipo__PersonaCapacitacion]
GO
ALTER TABLE [dbo].[PersonaCapacitacion]  WITH CHECK ADD  CONSTRAINT [FK__Curso__PersonaCapacitacion] FOREIGN KEY([IDCurso])
REFERENCES [dbo].[Curso] ([IDCurso])
GO
ALTER TABLE [dbo].[PersonaCapacitacion] CHECK CONSTRAINT [FK__Curso__PersonaCapacitacion]
GO
ALTER TABLE [dbo].[PersonaCapacitacion]  WITH CHECK ADD  CONSTRAINT [FK__Localidad__PersonaCapacitacion] FOREIGN KEY([IDProvincia], [IDLocalidad])
REFERENCES [dbo].[Localidad] ([IDProvincia], [IDLocalidad])
GO
ALTER TABLE [dbo].[PersonaCapacitacion] CHECK CONSTRAINT [FK__Localidad__PersonaCapacitacion]
GO
ALTER TABLE [dbo].[PersonaCapacitacion]  WITH CHECK ADD  CONSTRAINT [FK__Persona__PersonaCapacitacion] FOREIGN KEY([IDPersona])
REFERENCES [dbo].[Persona] ([IDPersona])
GO
ALTER TABLE [dbo].[PersonaCapacitacion] CHECK CONSTRAINT [FK__Persona__PersonaCapacitacion]
GO
ALTER TABLE [dbo].[PersonaCapacitacion]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaCapacitacion__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaCapacitacion] CHECK CONSTRAINT [FK__Usuario__PersonaCapacitacion__Creacion]
GO
ALTER TABLE [dbo].[PersonaCapacitacion]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaCapacitacion__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaCapacitacion] CHECK CONSTRAINT [FK__Usuario__PersonaCapacitacion__Modificacion]
GO
ALTER TABLE [dbo].[PersonaExamen]  WITH CHECK ADD  CONSTRAINT [FK__Persona__PersonaExamen] FOREIGN KEY([IDPersona])
REFERENCES [dbo].[Persona] ([IDPersona])
GO
ALTER TABLE [dbo].[PersonaExamen] CHECK CONSTRAINT [FK__Persona__PersonaExamen]
GO
ALTER TABLE [dbo].[PersonaExamen]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaExamen__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaExamen] CHECK CONSTRAINT [FK__Usuario__PersonaExamen__Creacion]
GO
ALTER TABLE [dbo].[PersonaExamen]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaExamen__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaExamen] CHECK CONSTRAINT [FK__Usuario__PersonaExamen__Modificacion]
GO
ALTER TABLE [dbo].[PersonaFamiliar]  WITH CHECK ADD  CONSTRAINT [FK__DocumentoTipo__PersonaFamiliar] FOREIGN KEY([IDDocumentoTipo])
REFERENCES [dbo].[DocumentoTipo] ([IDDocumentoTipo])
GO
ALTER TABLE [dbo].[PersonaFamiliar] CHECK CONSTRAINT [FK__DocumentoTipo__PersonaFamiliar]
GO
ALTER TABLE [dbo].[PersonaFamiliar]  WITH CHECK ADD  CONSTRAINT [FK__Localidad__PersonaFamiliar] FOREIGN KEY([DomicilioIDProvincia], [DomicilioIDLocalidad])
REFERENCES [dbo].[Localidad] ([IDProvincia], [IDLocalidad])
GO
ALTER TABLE [dbo].[PersonaFamiliar] CHECK CONSTRAINT [FK__Localidad__PersonaFamiliar]
GO
ALTER TABLE [dbo].[PersonaFamiliar]  WITH CHECK ADD  CONSTRAINT [FK__Parentesco__PersonaFamiliar] FOREIGN KEY([IDParentesco])
REFERENCES [dbo].[Parentesco] ([IDParentesco])
GO
ALTER TABLE [dbo].[PersonaFamiliar] CHECK CONSTRAINT [FK__Parentesco__PersonaFamiliar]
GO
ALTER TABLE [dbo].[PersonaFamiliar]  WITH CHECK ADD  CONSTRAINT [FK__Persona__PersonaFamiliar] FOREIGN KEY([IDPersona])
REFERENCES [dbo].[Persona] ([IDPersona])
GO
ALTER TABLE [dbo].[PersonaFamiliar] CHECK CONSTRAINT [FK__Persona__PersonaFamiliar]
GO
ALTER TABLE [dbo].[PersonaFamiliar]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaFamiliar__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaFamiliar] CHECK CONSTRAINT [FK__Usuario__PersonaFamiliar__Creacion]
GO
ALTER TABLE [dbo].[PersonaFamiliar]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaFamiliar__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaFamiliar] CHECK CONSTRAINT [FK__Usuario__PersonaFamiliar__Modificacion]
GO
ALTER TABLE [dbo].[PersonaLicencia]  WITH CHECK ADD  CONSTRAINT [FK__LicenciaCausa__PersonaLicencia] FOREIGN KEY([IDLicenciaCausa])
REFERENCES [dbo].[LicenciaCausa] ([IDLicenciaCausa])
GO
ALTER TABLE [dbo].[PersonaLicencia] CHECK CONSTRAINT [FK__LicenciaCausa__PersonaLicencia]
GO
ALTER TABLE [dbo].[PersonaLicencia]  WITH CHECK ADD  CONSTRAINT [FK__Persona__PersonaLicencia] FOREIGN KEY([IDPersona])
REFERENCES [dbo].[Persona] ([IDPersona])
GO
ALTER TABLE [dbo].[PersonaLicencia] CHECK CONSTRAINT [FK__Persona__PersonaLicencia]
GO
ALTER TABLE [dbo].[PersonaLicencia]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaLicencia__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaLicencia] CHECK CONSTRAINT [FK__Usuario__PersonaLicencia__Creacion]
GO
ALTER TABLE [dbo].[PersonaLicencia]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaLicencia__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaLicencia] CHECK CONSTRAINT [FK__Usuario__PersonaLicencia__Modificacion]
GO
ALTER TABLE [dbo].[PersonaLicenciaConducirCategoria]  WITH CHECK ADD  CONSTRAINT [FK__LicenciaConducirCategoria__PersonaLicenciaConducirCategoria] FOREIGN KEY([IDLicenciaConducirCategoria])
REFERENCES [dbo].[LicenciaConducirCategoria] ([IDLicenciaConducirCategoria])
GO
ALTER TABLE [dbo].[PersonaLicenciaConducirCategoria] CHECK CONSTRAINT [FK__LicenciaConducirCategoria__PersonaLicenciaConducirCategoria]
GO
ALTER TABLE [dbo].[PersonaLicenciaConducirCategoria]  WITH CHECK ADD  CONSTRAINT [FK__Persona__PersonaLicenciaConducirCategoria] FOREIGN KEY([IDPersona])
REFERENCES [dbo].[Persona] ([IDPersona])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PersonaLicenciaConducirCategoria] CHECK CONSTRAINT [FK__Persona__PersonaLicenciaConducirCategoria]
GO
ALTER TABLE [dbo].[PersonaLicenciaConducirCategoria]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaLicenciaConducirCategoria__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaLicenciaConducirCategoria] CHECK CONSTRAINT [FK__Usuario__PersonaLicenciaConducirCategoria__Creacion]
GO
ALTER TABLE [dbo].[PersonaSancion]  WITH CHECK ADD  CONSTRAINT [FK__Persona__PersonaSancion] FOREIGN KEY([IDPersona])
REFERENCES [dbo].[Persona] ([IDPersona])
GO
ALTER TABLE [dbo].[PersonaSancion] CHECK CONSTRAINT [FK__Persona__PersonaSancion]
GO
ALTER TABLE [dbo].[PersonaSancion]  WITH CHECK ADD  CONSTRAINT [FK__Persona__PersonaSancion__Solicitud] FOREIGN KEY([SolicitudIDPersona])
REFERENCES [dbo].[Persona] ([IDPersona])
GO
ALTER TABLE [dbo].[PersonaSancion] CHECK CONSTRAINT [FK__Persona__PersonaSancion__Solicitud]
GO
ALTER TABLE [dbo].[PersonaSancion]  WITH CHECK ADD  CONSTRAINT [FK__SancionTipo__PersonaSancion] FOREIGN KEY([ResolucionIDSancionTipo])
REFERENCES [dbo].[SancionTipo] ([IDSancionTipo])
GO
ALTER TABLE [dbo].[PersonaSancion] CHECK CONSTRAINT [FK__SancionTipo__PersonaSancion]
GO
ALTER TABLE [dbo].[PersonaSancion]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaSancion__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaSancion] CHECK CONSTRAINT [FK__Usuario__PersonaSancion__Creacion]
GO
ALTER TABLE [dbo].[PersonaSancion]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__PersonaSancion__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[PersonaSancion] CHECK CONSTRAINT [FK__Usuario__PersonaSancion__Modificacion]
GO
ALTER TABLE [dbo].[Reporte]  WITH CHECK ADD  CONSTRAINT [FK__ReporteGrupo__Reporte] FOREIGN KEY([IDReporteGrupo])
REFERENCES [dbo].[ReporteGrupo] ([IDReporteGrupo])
GO
ALTER TABLE [dbo].[Reporte] CHECK CONSTRAINT [FK__ReporteGrupo__Reporte]
GO
ALTER TABLE [dbo].[ReporteParametro]  WITH CHECK ADD  CONSTRAINT [FK__Reporte__ReporteParametro] FOREIGN KEY([IDReporte])
REFERENCES [dbo].[Reporte] ([IDReporte])
GO
ALTER TABLE [dbo].[ReporteParametro] CHECK CONSTRAINT [FK__Reporte__ReporteParametro]
GO
ALTER TABLE [dbo].[Rubro]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Rubro__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Rubro] CHECK CONSTRAINT [FK__Usuario__Rubro__Creacion]
GO
ALTER TABLE [dbo].[Rubro]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Rubro__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Rubro] CHECK CONSTRAINT [FK__Usuario__Rubro__Modificacion]
GO
ALTER TABLE [dbo].[SancionTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__SancionTipo__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[SancionTipo] CHECK CONSTRAINT [FK__Usuario__SancionTipo__Creacion]
GO
ALTER TABLE [dbo].[SancionTipo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__SancionTipo__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[SancionTipo] CHECK CONSTRAINT [FK__Usuario__SancionTipo__Modificacion]
GO
ALTER TABLE [dbo].[SubRubro]  WITH CHECK ADD  CONSTRAINT [FK__Rubro__SubRubro] FOREIGN KEY([IDRubro])
REFERENCES [dbo].[Rubro] ([IDRubro])
GO
ALTER TABLE [dbo].[SubRubro] CHECK CONSTRAINT [FK__Rubro__SubRubro]
GO
ALTER TABLE [dbo].[SubRubro]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__SubRubro__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[SubRubro] CHECK CONSTRAINT [FK__Usuario__SubRubro__Creacion]
GO
ALTER TABLE [dbo].[SubRubro]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__SubRubro__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[SubRubro] CHECK CONSTRAINT [FK__Usuario__SubRubro__Modificacion]
GO
ALTER TABLE [dbo].[SubUbicacion]  WITH CHECK ADD  CONSTRAINT [FK__Ubicacion__SubUbicacion] FOREIGN KEY([IDUbicacion])
REFERENCES [dbo].[Ubicacion] ([IDUbicacion])
GO
ALTER TABLE [dbo].[SubUbicacion] CHECK CONSTRAINT [FK__Ubicacion__SubUbicacion]
GO
ALTER TABLE [dbo].[SubUbicacion]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__SubUbicacion__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[SubUbicacion] CHECK CONSTRAINT [FK__Usuario__SubUbicacion__Creacion]
GO
ALTER TABLE [dbo].[SubUbicacion]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__SubUbicacion__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[SubUbicacion] CHECK CONSTRAINT [FK__Usuario__SubUbicacion__Modificacion]
GO
ALTER TABLE [dbo].[Ubicacion]  WITH CHECK ADD  CONSTRAINT [FK__Automotor__Ubicacion] FOREIGN KEY([IDAutomotor])
REFERENCES [dbo].[Automotor] ([IDAutomotor])
GO
ALTER TABLE [dbo].[Ubicacion] CHECK CONSTRAINT [FK__Automotor__Ubicacion]
GO
ALTER TABLE [dbo].[Ubicacion]  WITH CHECK ADD  CONSTRAINT [FK__Cuartel__Ubicacion] FOREIGN KEY([IDCuartel])
REFERENCES [dbo].[Cuartel] ([IDCuartel])
GO
ALTER TABLE [dbo].[Ubicacion] CHECK CONSTRAINT [FK__Cuartel__Ubicacion]
GO
ALTER TABLE [dbo].[Ubicacion]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Ubicacion__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Ubicacion] CHECK CONSTRAINT [FK__Usuario__Ubicacion__Creacion]
GO
ALTER TABLE [dbo].[Ubicacion]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Ubicacion__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Ubicacion] CHECK CONSTRAINT [FK__Usuario__Ubicacion__Modificacion]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK__Cuartel__Usuario] FOREIGN KEY([IDCuartel])
REFERENCES [dbo].[Cuartel] ([IDCuartel])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK__Cuartel__Usuario]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Usuario__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK__Usuario__Usuario__Creacion]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__Usuario__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK__Usuario__Usuario__Modificacion]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK__UsuarioGrupo__Usuario] FOREIGN KEY([IDUsuarioGrupo])
REFERENCES [dbo].[UsuarioGrupo] ([IDUsuarioGrupo])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK__UsuarioGrupo__Usuario]
GO
ALTER TABLE [dbo].[UsuarioGrupo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__UsuarioGrupo__Creacion] FOREIGN KEY([IDUsuarioCreacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[UsuarioGrupo] CHECK CONSTRAINT [FK__Usuario__UsuarioGrupo__Creacion]
GO
ALTER TABLE [dbo].[UsuarioGrupo]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__UsuarioGrupo__Modificacion] FOREIGN KEY([IDUsuarioModificacion])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[UsuarioGrupo] CHECK CONSTRAINT [FK__Usuario__UsuarioGrupo__Modificacion]
GO
ALTER TABLE [dbo].[UsuarioGrupoPermiso]  WITH CHECK ADD  CONSTRAINT [FK__UsuarioGrupo__UsuarioGrupoPermiso] FOREIGN KEY([IDUsuarioGrupo])
REFERENCES [dbo].[UsuarioGrupo] ([IDUsuarioGrupo])
GO
ALTER TABLE [dbo].[UsuarioGrupoPermiso] CHECK CONSTRAINT [FK__UsuarioGrupo__UsuarioGrupoPermiso]
GO
ALTER TABLE [dbo].[UsuarioParametro]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__UsuarioParametro] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[UsuarioParametro] CHECK CONSTRAINT [FK__Usuario__UsuarioParametro]
GO
