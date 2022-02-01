USE Capacitacion
SET IDENTITY_INSERT [dbo].[CatCursos] ON 

INSERT [dbo].[CatCursos] ([id_CatCursos], [Clave], [Nombre], [descripcion], [horas], [idPreRequisito], [activo]) VALUES (1, N'ABC       ', N'Base de datos SQL Server', N'Introduccion a SQL server', 60, 1, 1)
INSERT [dbo].[CatCursos] ([id_CatCursos], [Clave], [Nombre], [descripcion], [horas], [idPreRequisito], [activo]) VALUES (2, N'DFG       ', N'Introduccion a Asp.NET y C#', N'Capacitacion al alumno', 120, 2, 1)
INSERT [dbo].[CatCursos] ([id_CatCursos], [Clave], [Nombre], [descripcion], [horas], [idPreRequisito], [activo]) VALUES (3, N'HIJ       ', N'Asp.NET C#', N'Contexto de ASP', 70, null, 1)
INSERT [dbo].[CatCursos] ([id_CatCursos], [Clave], [Nombre], [descripcion], [horas], [idPreRequisito], [activo]) VALUES (4, N'KLM       ', N'Asp.NET -MVC', N' Creacion de .NET en MVC experto', 100, null, 1)

SET IDENTITY_INSERT [dbo].[CatCursos] OFF