USE [db_pruebas]
GO
/****** Object:  Table [dbo].[empleados]    Script Date: 9/05/2020 21:36:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleados](
	[codEmp] [int] IDENTITY(1,1) NOT NULL,
	[nomEmp] [varchar](50) NULL,
	[edadEmp] [int] NULL,
	[sexoEmp] [char](1) NULL,
	[sueldoEmp] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[codEmp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[empleados] ON 

INSERT [dbo].[empleados] ([codEmp], [nomEmp], [edadEmp], [sexoEmp], [sueldoEmp]) VALUES (1, N'JORGE RAMIREZ', 22, N'M', 1200.0000)
INSERT [dbo].[empleados] ([codEmp], [nomEmp], [edadEmp], [sexoEmp], [sueldoEmp]) VALUES (2, N'EDUARDO TORRES', 34, N'M', 1200.0000)
INSERT [dbo].[empleados] ([codEmp], [nomEmp], [edadEmp], [sexoEmp], [sueldoEmp]) VALUES (3, N'CARLA AGUILAR', 35, N'F', 3000.0000)
INSERT [dbo].[empleados] ([codEmp], [nomEmp], [edadEmp], [sexoEmp], [sueldoEmp]) VALUES (4, N'RAMIRO CASTRO', 33, N'M', 3000.0000)
INSERT [dbo].[empleados] ([codEmp], [nomEmp], [edadEmp], [sexoEmp], [sueldoEmp]) VALUES (5, N'RAFAELA COSIO', 54, N'F', 850.0000)
INSERT [dbo].[empleados] ([codEmp], [nomEmp], [edadEmp], [sexoEmp], [sueldoEmp]) VALUES (7, N'PAOLA', 22, N'F', 2222.0000)
SET IDENTITY_INSERT [dbo].[empleados] OFF
