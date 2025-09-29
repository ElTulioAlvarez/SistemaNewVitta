# Sistema New Vitta

Sistema de **gestión integral para un centro de rehabilitación**. Permite administrar **internos**, **ingresos/egresos**, **medicación**, **psicólogos/doctores**, **usuarios/roles** y generar **registros y reportes**. Escritorio en **C# (.NET Framework 4.8)** con **SQL Server** y arquitectura por capas.

[![.NET Framework](https://img.shields.io/badge/.NET-4.8-512BD4?logo=dotnet&logoColor=white)]()
[![C%23](https://img.shields.io/badge/C%23-WinForms-239120?logo=csharp&logoColor=white)]()
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2019%2B-CC2927?logo=microsoftsqlserver&logoColor=white)]()
[![Windows](https://img.shields.io/badge/Windows-10%2B-0078D6?logo=windows&logoColor=white)]()

---

## Tabla de contenidos
- [Características](#características)
- [Arquitectura y carpetas](#arquitectura-y-carpetas)
- [Módulos funcionales](#módulos-funcionales)
- [Requisitos](#requisitos)
- [Instalación](#instalación)
- [Configuración](#configuración)
- [Uso básico](#uso-básico)
- [Modelo de datos (orientativo)](#modelo-de-datos-orientativo)
- [Semilla SQL mínima (opcional)](#semilla-sql-mínima-opcional)
- [Buenas prácticas y seguridad](#buenas-prácticas-y-seguridad)
- [Estructura del repositorio](#estructura-del-repositorio)
- [Roadmap](#roadmap)
- [Contribuir](#contribuir)
- [Licencia](#licencia)

---

## Características
- **Internos**: alta, historial, estado de salud y seguimiento.
- **Ingresos/Egresos**: control económico por periodo y por interno.
- **Medicamentos**: registro, asignación y seguimiento.
- **Psicólogos/Doctores**: padrón profesional y asignación por interno.
- **Usuarios/Roles**: autenticación y autorización por perfil.
- **Reportes**: base para reporteo (PDF/Excel en roadmap).
- **UI moderna** con componentes WinForms y librería de interfaz.

---

## Arquitectura y carpetas
┌──────────────────────────────────────────────────────┐
│ Capa Presentación (UI) │
│ - Inicio/ → pantallas principales │
│ - Login/ → autenticación │
└──────────────────────────────────────────────────────┘
┌──────────────────────────────────────────────────────┐
│ Capa Acceso a Datos (DAL) │
│ - Conexion/ → repositorios / ADO.NET │
└──────────────────────────────────────────────────────┘
┌──────────────────────────────────────────────────────┐
│ Capa Dominio │
│ - Entidades/ → POCOs del modelo │
└──────────────────────────────────────────────────────┘
┌──────────────────────────────────────────────────────┐
│ Persistencia │
│ - Base de Datos/ → scripts DDL/DML │
└──────────────────────────────────────────────────────┘


> La solución `SistemaNewVitta.sln` y las carpetas **Base de Datos**, **Conexion**, **Entidades**, **Inicio**, **Login** se encuentran en el repo. Se usa un paquete de UI (WinForms).  
> Tecnologías principales detectadas: **C#**.  

---

## Módulos funcionales
- **Usuarios y Roles**: control de acceso (Admin/Operador/Consulta).
- **Internos**: expediente, datos clínicos básicos y observaciones.
- **Profesionales**: **Psicólogos** y **Doctores** con asignación por interno.
- **Economía**: **Ingresos** y **Egresos** con filtros por fecha e interno.
- **Medicamentos**: catálogo y administración por interno.
- **Reportes**: base para listados/estadísticas (extensible).

---

## Requisitos
- **Windows 10/11**
- **.NET Framework 4.8**
- **Visual Studio 2019/2022** (con targeting pack .NET 4.8)
- **SQL Server 2019+** (Developer o Express)

---

## Instalación
1. **Base de datos**  
   Ejecuta los scripts de `Base de Datos/` en tu instancia de SQL Server (creación de esquema/tablas y, si existe, datos semilla).
2. **Solución**  
   Abre `SistemaNewVitta.sln` en Visual Studio.
3. **Paquetes**  
   Restaura NuGet si aplica.
4. **Compilación y ejecución**  
   Compila en `Debug`/`Release` y ejecuta el proyecto de **Inicio**.

---

## Configuración

### Cadena de conexión (`app.config`)
Ajusta servidor y autenticación según tu entorno:

```xml
<configuration>
  <connectionStrings>
    <add name="DefaultConnection"
         connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=NewVittaDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"
         providerName="System.Data.SqlClient" />
  </connectionStrings>
</configuration>
```
Uso básico
Login con un usuario válido (rol Admin la primera vez).

Catálogos: registra profesionales (psicólogos/doctores) y medicamentos.

Internos: da de alta internos y realiza asignaciones.

Movimientos: carga ingresos y egresos; consulta por periodo.

Reportes: genera listados y valida totales (si el módulo está habilitado).

