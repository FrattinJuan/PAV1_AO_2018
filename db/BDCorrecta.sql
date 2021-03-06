USE [PAV1_AO_2018]
GO
/****** Object:  Table [dbo].[Caras]    Script Date: 11/13/2018 21:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Caras](
	[id_cara] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Caras] PRIMARY KEY CLUSTERED 
(
	[id_cara] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Caras] ON
INSERT [dbo].[Caras] ([id_cara], [nombre]) VALUES (1, N'Oclusal')
INSERT [dbo].[Caras] ([id_cara], [nombre]) VALUES (2, N'Mesial')
INSERT [dbo].[Caras] ([id_cara], [nombre]) VALUES (3, N'Distal')
INSERT [dbo].[Caras] ([id_cara], [nombre]) VALUES (4, N'Palatino')
INSERT [dbo].[Caras] ([id_cara], [nombre]) VALUES (5, N'Lingual')
SET IDENTITY_INSERT [dbo].[Caras] OFF
/****** Object:  Table [dbo].[Elementos]    Script Date: 11/13/2018 21:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Elementos](
	[id_elemento] [int] IDENTITY(1,1) NOT NULL,
	[cod_elemento] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Elementos] PRIMARY KEY CLUSTERED 
(
	[id_elemento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Elementos] ON
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (3, 11, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (6, 12, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (7, 13, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (8, 14, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (9, 15, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (10, 16, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (11, 17, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (12, 18, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (13, 21, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (15, 22, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (16, 23, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (17, 24, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (18, 25, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (19, 26, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (20, 27, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (21, 28, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (22, 31, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (23, 32, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (24, 33, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (25, 34, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (26, 35, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (27, 36, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (28, 37, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (29, 38, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (30, 41, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (31, 42, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (32, 43, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (33, 44, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (34, 45, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (35, 46, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (36, 47, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (37, 48, N'diente')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (38, 51, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (40, 52, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (41, 53, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (43, 54, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (44, 55, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (45, 61, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (46, 62, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (47, 63, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (48, 64, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (49, 65, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (51, 71, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (52, 72, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (53, 73, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (54, 74, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (55, 75, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (56, 81, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (57, 82, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (58, 83, N'muela')
INSERT [dbo].[Elementos] ([id_elemento], [cod_elemento], [nombre]) VALUES (59, 84, N'muela')
SET IDENTITY_INSERT [dbo].[Elementos] OFF
/****** Object:  Table [dbo].[Odontogramas]    Script Date: 11/13/2018 21:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odontogramas](
	[cod_odontograma] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nchar](10) NULL,
 CONSTRAINT [PK_Odontogramas] PRIMARY KEY CLUSTERED 
(
	[cod_odontograma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Odontogramas] ON
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (1, N'12        ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (2, N'122       ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (3, N'12        ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (4, N'Danilo    ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (5, N'Danilo    ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (6, N'Danilo    ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (7, N'Danilo    ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (8, N'Danilo    ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (9, N'Danilo    ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (10, N'Danilo    ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (11, N'Danilo    ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (12, N'Danilo    ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (13, N'Danilo    ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (14, N'Danilo    ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (15, N'Danilo    ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (16, N'Danilo    ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (17, N'NULL      ')
INSERT [dbo].[Odontogramas] ([cod_odontograma], [descripcion]) VALUES (18, N'NULL      ')
SET IDENTITY_INSERT [dbo].[Odontogramas] OFF
/****** Object:  Table [dbo].[TiposDocumento]    Script Date: 11/13/2018 21:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposDocumento](
	[cod_tipo] [int] NOT NULL,
	[n_tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TiposDocumento] PRIMARY KEY CLUSTERED 
(
	[cod_tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TiposDocumento] ([cod_tipo], [n_tipo]) VALUES (1, N'DNI')
INSERT [dbo].[TiposDocumento] ([cod_tipo], [n_tipo]) VALUES (2, N'PASAPORTE')
/****** Object:  Table [dbo].[Prestaciones]    Script Date: 11/13/2018 21:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prestaciones](
	[id_prestacion] [int] IDENTITY(1,1) NOT NULL,
	[cod_prestacion] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Prestaciones] PRIMARY KEY CLUSTERED 
(
	[id_prestacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Prestaciones] ON
INSERT [dbo].[Prestaciones] ([id_prestacion], [cod_prestacion], [nombre], [descripcion]) VALUES (1, 12, N'carie', N'hola')
INSERT [dbo].[Prestaciones] ([id_prestacion], [cod_prestacion], [nombre], [descripcion]) VALUES (2, 31, N'perno', N'no tengo')
INSERT [dbo].[Prestaciones] ([id_prestacion], [cod_prestacion], [nombre], [descripcion]) VALUES (3, 21, N'corona', N'nada')
INSERT [dbo].[Prestaciones] ([id_prestacion], [cod_prestacion], [nombre], [descripcion]) VALUES (4, 97, N'implante', N'implante')
INSERT [dbo].[Prestaciones] ([id_prestacion], [cod_prestacion], [nombre], [descripcion]) VALUES (5, 33, N'extraccion', N'')
INSERT [dbo].[Prestaciones] ([id_prestacion], [cod_prestacion], [nombre], [descripcion]) VALUES (6, 23, N'tratamiento', N'')
INSERT [dbo].[Prestaciones] ([id_prestacion], [cod_prestacion], [nombre], [descripcion]) VALUES (7, 13, N'carie', N'')
INSERT [dbo].[Prestaciones] ([id_prestacion], [cod_prestacion], [nombre], [descripcion]) VALUES (8, 2, N'incision', N'')
INSERT [dbo].[Prestaciones] ([id_prestacion], [cod_prestacion], [nombre], [descripcion]) VALUES (9, 6, N'arreglo', N'juan')
SET IDENTITY_INSERT [dbo].[Prestaciones] OFF
/****** Object:  Table [dbo].[Perfiles]    Script Date: 11/13/2018 21:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[n_perfil] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON
INSERT [dbo].[Perfiles] ([id_perfil], [n_perfil]) VALUES (1, N'admin')
INSERT [dbo].[Perfiles] ([id_perfil], [n_perfil]) VALUES (2, N'odontologo')
INSERT [dbo].[Perfiles] ([id_perfil], [n_perfil]) VALUES (3, N'secretario')
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/13/2018 21:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[nombreUsuario] [varchar](50) NOT NULL,
	[nroMatricula] [int] NULL,
	[tipoDocumento] [int] NOT NULL,
	[nroDocumento] [int] NULL,
	[telefono] [int] NULL,
	[email] [varchar](50) NULL,
	[id_perfil] [int] NOT NULL,
	[estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON
INSERT [dbo].[Usuarios] ([id_usuario], [password], [nombreUsuario], [nroMatricula], [tipoDocumento], [nroDocumento], [telefono], [email], [id_perfil], [estado]) VALUES (1, N'1234', N'admin', 0, 1, 39937490, 123456789, N'admin@yahoo.com', 1, N'S')
INSERT [dbo].[Usuarios] ([id_usuario], [password], [nombreUsuario], [nroMatricula], [tipoDocumento], [nroDocumento], [telefono], [email], [id_perfil], [estado]) VALUES (5, N'12345', N'agustin', 111112, 1, 45666897, 386575462, N'agustinkpo@hotmail.com', 2, N'N')
INSERT [dbo].[Usuarios] ([id_usuario], [password], [nombreUsuario], [nroMatricula], [tipoDocumento], [nroDocumento], [telefono], [email], [id_perfil], [estado]) VALUES (18, N'danilo18', N'Danilo', 111111, 1, 40680220, 357161754, N'daniloulbrich3@gmail.com', 2, N'S')
INSERT [dbo].[Usuarios] ([id_usuario], [password], [nombreUsuario], [nroMatricula], [tipoDocumento], [nroDocumento], [telefono], [email], [id_perfil], [estado]) VALUES (19, N'1234', N'JUANcho', 123, 1, 123, NULL, N'', 1, N'N')
INSERT [dbo].[Usuarios] ([id_usuario], [password], [nombreUsuario], [nroMatricula], [tipoDocumento], [nroDocumento], [telefono], [email], [id_perfil], [estado]) VALUES (20, N'biamca01', N'Bianca', 0, 1, 489876574, 351675487, N'biancanar@gmail.com', 3, N'S')
INSERT [dbo].[Usuarios] ([id_usuario], [password], [nombreUsuario], [nroMatricula], [tipoDocumento], [nroDocumento], [telefono], [email], [id_perfil], [estado]) VALUES (21, N'12345', N'Nicolas', 111113, 2, 36754887, 357161754, N'nicooo@gmail.com', 2, N'S')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
/****** Object:  Table [dbo].[Pacientes]    Script Date: 11/13/2018 21:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pacientes](
	[id_paciente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NULL,
	[fechaNac] [date] NULL,
	[tipoDocumento] [int] NOT NULL,
	[nroDocumento] [int] NOT NULL,
	[domicilio] [varchar](50) NULL,
	[telefono] [int] NULL,
	[obraSocial] [varchar](50) NULL,
	[estado] [varchar](50) NOT NULL,
	[id_odontograma] [int] NULL,
 CONSTRAINT [PK_Pacientes_1] PRIMARY KEY CLUSTERED 
(
	[id_paciente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Pacientes] ON
INSERT [dbo].[Pacientes] ([id_paciente], [nombre], [apellido], [fechaNac], [tipoDocumento], [nroDocumento], [domicilio], [telefono], [obraSocial], [estado], [id_odontograma]) VALUES (2, N'Julieta', N'Venegas', CAST(0xA5770A00 AS Date), 1, 23213232, N'Ituziango 1211', 765843789, N'osde', N'S', 1)
INSERT [dbo].[Pacientes] ([id_paciente], [nombre], [apellido], [fechaNac], [tipoDocumento], [nroDocumento], [domicilio], [telefono], [obraSocial], [estado], [id_odontograma]) VALUES (3, N'Ricardo', N'Montaner', CAST(0xB5FF0A00 AS Date), 1, 23456789, N'Buenos Aires 930', 11324567, N'met', N'S', 2)
INSERT [dbo].[Pacientes] ([id_paciente], [nombre], [apellido], [fechaNac], [tipoDocumento], [nroDocumento], [domicilio], [telefono], [obraSocial], [estado], [id_odontograma]) VALUES (4, N'Pablo', N'Perez', CAST(0x490F0B00 AS Date), 1, 56432456, N'la boca 221', 576839234, N'sancor', N'N', 3)
INSERT [dbo].[Pacientes] ([id_paciente], [nombre], [apellido], [fechaNac], [tipoDocumento], [nroDocumento], [domicilio], [telefono], [obraSocial], [estado], [id_odontograma]) VALUES (5, N'agustin', N'ramirez', CAST(0x88280B00 AS Date), 1, 489876584, N'richarson 23', 48376453, N'No tiene', N'S', 17)
INSERT [dbo].[Pacientes] ([id_paciente], [nombre], [apellido], [fechaNac], [tipoDocumento], [nroDocumento], [domicilio], [telefono], [obraSocial], [estado], [id_odontograma]) VALUES (6, N'juanito', N'ramirez', CAST(0x88280B00 AS Date), 1, 489876584, N'richarson 23', 48376453, N'No tiene', N'S', 18)
SET IDENTITY_INSERT [dbo].[Pacientes] OFF
/****** Object:  Table [dbo].[HistorialesMedicos]    Script Date: 11/13/2018 21:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HistorialesMedicos](
	[id_historial] [int] IDENTITY(1,1) NOT NULL,
	[id_paciente] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[fechaInicio] [date] NULL,
	[importeTotal] [int] NULL,
	[observacion] [varchar](50) NULL,
 CONSTRAINT [PK_HistorialesMedicos] PRIMARY KEY CLUSTERED 
(
	[id_historial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[HistorialesMedicos] ON
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (2, 2, 5, CAST(0xA23D0B00 AS Date), 10, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (9, 2, 5, CAST(0xFF3C0B00 AS Date), 200, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (13, 2, 5, CAST(0xCE3E0B00 AS Date), 23456, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (14, 2, 5, CAST(0xCE3E0B00 AS Date), 23456, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (15, 2, 5, CAST(0xDD3E0B00 AS Date), 777, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (16, 2, 18, CAST(0xDD3E0B00 AS Date), 2311, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (17, 2, 18, CAST(0xDD3E0B00 AS Date), 800, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (18, 2, 18, CAST(0xDD3E0B00 AS Date), 300, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (19, 4, 21, CAST(0xDD3E0B00 AS Date), 200, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (20, 4, 21, CAST(0xDD3E0B00 AS Date), 60000, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (21, 4, 18, CAST(0xDD3E0B00 AS Date), 900, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (22, 3, 21, CAST(0xDD3E0B00 AS Date), 400, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (23, 3, 21, CAST(0xDE3E0B00 AS Date), 200, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (24, 3, 21, CAST(0xDE3E0B00 AS Date), 200, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (25, 3, 21, CAST(0xDE3E0B00 AS Date), 500, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (26, 4, 21, CAST(0xDE3E0B00 AS Date), 700, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (27, 2, 18, CAST(0xE33E0B00 AS Date), 900, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (28, 2, 18, CAST(0xE33E0B00 AS Date), 900, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (29, 2, 18, CAST(0xE33E0B00 AS Date), 900, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (30, 2, 18, CAST(0xE33E0B00 AS Date), 980, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (31, 3, 18, CAST(0xE33E0B00 AS Date), 90, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (32, 4, 21, CAST(0xE33E0B00 AS Date), 300, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (33, 3, 18, CAST(0xE33E0B00 AS Date), 700, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (34, 2, 18, CAST(0xE33E0B00 AS Date), 555, NULL)
INSERT [dbo].[HistorialesMedicos] ([id_historial], [id_paciente], [id_usuario], [fechaInicio], [importeTotal], [observacion]) VALUES (36, 4, 18, CAST(0xF13E0B00 AS Date), 800, NULL)
SET IDENTITY_INSERT [dbo].[HistorialesMedicos] OFF
/****** Object:  Table [dbo].[DetalleHistorial]    Script Date: 11/13/2018 21:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleHistorial](
	[id_detalle_historial] [int] IDENTITY(1,1) NOT NULL,
	[id_historial] [int] NOT NULL,
	[id_prestacion] [int] NOT NULL,
	[id_elemento] [int] NOT NULL,
	[id_cara] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[importe] [int] NULL,
 CONSTRAINT [PK_DetalleHistorial] PRIMARY KEY CLUSTERED 
(
	[id_detalle_historial] ASC,
	[id_historial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DetalleHistorial] ON
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (2, 18, 8, 25, 2, N'no requiere', 300)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (4, 20, 5, 48, 2, N'barato', 60000)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (5, 21, 2, 13, 2, N'no aplica', 500)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (6, 21, 4, 55, 3, N'no aplica', 400)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (7, 22, 6, 44, 3, N'nueva consulta', 400)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (8, 23, 3, 44, 2, N'no aplica', 200)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (9, 23, 1, 53, 3, N'no aplica', 300)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (10, 24, 3, 44, 2, N'no aplica', 200)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (11, 24, 1, 53, 3, N'no aplica', 300)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (12, 25, 3, 44, 2, N'no aplica', 200)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (13, 25, 1, 53, 3, N'no aplica', 300)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (14, 27, 8, 12, 2, N'no aplica', 900)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (16, 32, 2, 12, 2, N'no aplica', 300)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (17, 33, 2, 45, 1, N'no aplica', 700)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (18, 33, 5, 23, 5, N'no aplica', 250)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (19, 33, 1, 18, 3, N'no aplica', 51)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (20, 34, 2, 13, 2, N'no aplica', 555)
INSERT [dbo].[DetalleHistorial] ([id_detalle_historial], [id_historial], [id_prestacion], [id_elemento], [id_cara], [descripcion], [importe]) VALUES (22, 36, 2, 13, 2, N'no aplica', 800)
SET IDENTITY_INSERT [dbo].[DetalleHistorial] OFF
/****** Object:  ForeignKey [FK_DetalleHistorial_Cara]    Script Date: 11/13/2018 21:38:19 ******/
ALTER TABLE [dbo].[DetalleHistorial]  WITH CHECK ADD  CONSTRAINT [FK_DetalleHistorial_Cara] FOREIGN KEY([id_cara])
REFERENCES [dbo].[Caras] ([id_cara])
GO
ALTER TABLE [dbo].[DetalleHistorial] CHECK CONSTRAINT [FK_DetalleHistorial_Cara]
GO
/****** Object:  ForeignKey [FK_DetalleHistorial_Elemento]    Script Date: 11/13/2018 21:38:19 ******/
ALTER TABLE [dbo].[DetalleHistorial]  WITH CHECK ADD  CONSTRAINT [FK_DetalleHistorial_Elemento] FOREIGN KEY([id_elemento])
REFERENCES [dbo].[Elementos] ([id_elemento])
GO
ALTER TABLE [dbo].[DetalleHistorial] CHECK CONSTRAINT [FK_DetalleHistorial_Elemento]
GO
/****** Object:  ForeignKey [FK_DetalleHistorial_Historial]    Script Date: 11/13/2018 21:38:19 ******/
ALTER TABLE [dbo].[DetalleHistorial]  WITH CHECK ADD  CONSTRAINT [FK_DetalleHistorial_Historial] FOREIGN KEY([id_historial])
REFERENCES [dbo].[HistorialesMedicos] ([id_historial])
GO
ALTER TABLE [dbo].[DetalleHistorial] CHECK CONSTRAINT [FK_DetalleHistorial_Historial]
GO
/****** Object:  ForeignKey [FK_DetalleHistorial_Prestacion]    Script Date: 11/13/2018 21:38:19 ******/
ALTER TABLE [dbo].[DetalleHistorial]  WITH CHECK ADD  CONSTRAINT [FK_DetalleHistorial_Prestacion] FOREIGN KEY([id_prestacion])
REFERENCES [dbo].[Prestaciones] ([id_prestacion])
GO
ALTER TABLE [dbo].[DetalleHistorial] CHECK CONSTRAINT [FK_DetalleHistorial_Prestacion]
GO
/****** Object:  ForeignKey [FK_HistorialesMedicos_Usuario(Odontologo)]    Script Date: 11/13/2018 21:38:19 ******/
ALTER TABLE [dbo].[HistorialesMedicos]  WITH CHECK ADD  CONSTRAINT [FK_HistorialesMedicos_Usuario(Odontologo)] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[HistorialesMedicos] CHECK CONSTRAINT [FK_HistorialesMedicos_Usuario(Odontologo)]
GO
/****** Object:  ForeignKey [FK_HistorialMedico_Paciente]    Script Date: 11/13/2018 21:38:19 ******/
ALTER TABLE [dbo].[HistorialesMedicos]  WITH CHECK ADD  CONSTRAINT [FK_HistorialMedico_Paciente] FOREIGN KEY([id_paciente])
REFERENCES [dbo].[Pacientes] ([id_paciente])
GO
ALTER TABLE [dbo].[HistorialesMedicos] CHECK CONSTRAINT [FK_HistorialMedico_Paciente]
GO
/****** Object:  ForeignKey [FK_Paciente_TipoDocumento]    Script Date: 11/13/2018 21:38:19 ******/
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_TipoDocumento] FOREIGN KEY([tipoDocumento])
REFERENCES [dbo].[TiposDocumento] ([cod_tipo])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Paciente_TipoDocumento]
GO
/****** Object:  ForeignKey [FK_Pacientes_Odontogramas]    Script Date: 11/13/2018 21:38:19 ******/
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Odontogramas] FOREIGN KEY([id_odontograma])
REFERENCES [dbo].[Odontogramas] ([cod_odontograma])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Odontogramas]
GO
/****** Object:  ForeignKey [FK_Usuarios_Perfil]    Script Date: 11/13/2018 21:38:19 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfil] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfil]
GO
/****** Object:  ForeignKey [FK_Usuarios_TiposDocumento]    Script Date: 11/13/2018 21:38:19 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_TiposDocumento] FOREIGN KEY([tipoDocumento])
REFERENCES [dbo].[TiposDocumento] ([cod_tipo])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_TiposDocumento]
GO
