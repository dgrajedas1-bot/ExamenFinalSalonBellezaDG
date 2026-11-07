# Examen Final Programación II – Tema III: Salón de Belleza

**Alumna:** Daniela Paola Grajeda Sandoval · **Carné:** 0900-25-15929 · **Sección:** A

Cliente Windows Forms que envía los datos de un cliente a un servicio web ASMX. El servicio calcula la cuenta, la guarda en SQL Server y la devuelve.

## Tecnología
- C#, .NET Framework 4.8
- Servicio web ASMX (SOAP 1.1)
- Windows Forms
- SQL Server Express con ADO.NET y consultas parametrizadas
- Sin paquetes NuGet

## Estructura
| Proyecto | Capa | Contenido |
|---|---|---|
| `CapaEntidadesDG` | Entidades | `clsCuentaDG` |
| `CapaDatosDG` | Datos | `clsConexionDG`, `clsCuentaDatosDG` |
| `CapaNegocioDG` | Negocio | `clsCuentaNegocioDG`: validación, suma y redondeo a 2 decimales |
| `WebServicioSalonDG` | Servicio | `wsSalonBellezaDG.asmx`: `FncCalcularCuentaDG`, `FncListarCuentasDG` |
| `WinSalonBellezaDG` | Presentación | `frmSalonBellezaDG`, proxy SOAP `clsProxySalonBellezaDG` |
| `BaseDatosDG` | Base de datos | `scrExamenFinalSalonBellezaDG.sql` |

**Estándares:** identificadores con sufijo `DG`, comentarios XML (`///`) y archivos en UTF-8.

## Cálculo
- **Total Servicios** = Servicio de uñas + Honorarios + Peinado + Aplicación de tinte + Bases
- **Total Otros** = Otros
- **SU CUENTA ES** = Total Servicios + Total Otros

El nombre es obligatorio y los importes van de 0 a 9,999,999.99. Todos los valores se redondean a 2 decimales con `MidpointRounding.AwayFromZero`.

## Puesta en marcha
1. **Base de datos:** ejecutar `BaseDatosDG/scrExamenFinalSalonBellezaDG.sql` en SSMS.
2. **Conexión:** revisar `cnnSalonDG` en `WebServicioSalonDG/Web.config`. Valor por defecto: `ML-RefVm-941826\SQLEXPRESS`, con seguridad integrada.
3. **Abrir** `ExamenFinalSalonBelleza_DanielaGrajedaDG.sln` en Visual Studio 2022 (cargas de trabajo *ASP.NET y desarrollo web* y *Desarrollo de escritorio de .NET*).
4. **Proyectos de inicio:** clic derecho en la solución → *Configurar proyectos de inicio* → *Varios proyectos de inicio*.
   - `WebServicioSalonDG` = Iniciar, colocado primero
   - `WinSalonBellezaDG` = Iniciar
5. **Compilar** (Ctrl+Shift+B) y **ejecutar** (Ctrl+F5).
   - El servicio queda en `http://localhost:51250/wsSalonBellezaDG.asmx`.
   - El cliente lee esa dirección de `WinSalonBellezaDG/App.config` (`UrlServicioSalonDG`).
6. **Probar:**
   - Ingresar 200.00 en cada uno de los cinco servicios y 100.00 en Otros, luego **Calcular Cuenta**.
   - Resultado esperado: Total Servicios 1,000.00; Total Otros 100.00; SU CUENTA ES 1,100.00.
   - El historial muestra el registro guardado.

## Publicación en IIS (opcional)
1. Publicar `WebServicioSalonDG` en la carpeta `C:\inetpub\SalonDG`.
2. Crear el grupo de aplicaciones `SalonDG` (.NET CLR v4.0, modo integrado).
3. Crear el sitio `SalonDG` en el puerto 8086, con esa ruta física y ese grupo.
4. Dar a `IIS AppPool\SalonDG` permiso de lectura y ejecución sobre la carpeta.
5. Dar acceso mínimo en SQL Server:
```sql
USE master;
IF NOT EXISTS (SELECT 1 FROM sys.server_principals WHERE name = N'IIS APPPOOL\SalonDG')
    CREATE LOGIN [IIS APPPOOL\SalonDG] FROM WINDOWS;
GO
USE ExamenFinalSalonBellezaDG;
IF NOT EXISTS (SELECT 1 FROM sys.database_principals WHERE name = N'IIS APPPOOL\SalonDG')
    CREATE USER [IIS APPPOOL\SalonDG] FOR LOGIN [IIS APPPOOL\SalonDG];
GRANT SELECT, INSERT ON dbo.tblCuentaDG TO [IIS APPPOOL\SalonDG];
GO
```
6. Cambiar `UrlServicioSalonDG` en `App.config` a `http://localhost:8086/wsSalonBellezaDG.asmx`.
