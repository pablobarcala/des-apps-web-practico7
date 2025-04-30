# 📄 Ejemplo de Singleton en C#

## 📚 Descripción

Este proyecto muestra una implementación básica del **patrón Singleton** en C#.  
El patrón **Singleton** asegura que una clase tenga **una única instancia** accesible globalmente y proporciona un punto de acceso controlado a ella.

En este ejemplo, la clase `Persona` siempre tiene **una sola instancia** compartida, sin importar cuántas veces accedamos a ella.

---

## 🛠️ Estructura del código

- **`Persona`** es la clase Singleton:
  - Tiene un constructor privado.
  - Su única instancia está almacenada en un campo privado y estático (`_instance`).
  - Expone la instancia a través de la propiedad pública `Instance`.

- **`Program`** es la clase principal donde:
  - Accedemos a la instancia `Persona.Instance`.
  - Modificamos sus propiedades (`Nombre`, `Apellido`).
  - Verificamos que siempre estamos usando **el mismo objeto** (`ReferenceEquals`).

---

## ⚡ Cómo ejecutar el código

### Requisitos

- Tener instalado el **.NET SDK**.  
  Verificá si lo tenés ejecutando:

  ```bash
  dotnet --version

- Si no está instalado, descargalo desde:
  👉 https://dotnet.microsoft.com/en-us/download

## Opción 1: Ejecutar archivo suelto con compilador
  
- Guardá el archivo como `Program.cs`.
- Abrí una terminal en la carpeta donde está el archivo.
- Compilá el archivo:
- 
  ```bash
  csc Program.cs
  
- Ejecutá el programa:
- 
  ```bash
  Program.exe
  
- Si estás en Linux o Mac, podés necesitar usar mono para ejecutar el .exe.

## Opción 2: Usar un proyecto de consola (opcional)
- Crear un nuevo proyecto de consola:
- 
  ```bash
  dotnet new console -n SingletonEjemplo
  cd SingletonEjemplo
  
- Reemplazá el contenido de `Program.cs` con el código del ejemplo.
- Ejecutá el proyecto:
- 
  ```bash
  dotnet run

---

## 🎯 ¿Qué problema resuelve este código?
**Problema:**
Queremos asegurarnos de que solo exista una única instancia de una clase en toda la aplicación. Esto es útil, por ejemplo, para:

- Configuraciones globales.

- Conexiones a bases de datos.

- Recursos compartidos.

**Solución con Singleton:**
La clase `Persona` garantiza que:

- Solo existe una instancia.

- Todos los accesos a `Persona.Instance` devuelven el mismo objeto.

- Los cambios en sus propiedades afectan a todos los lugares donde se usa.

## ✨ Resultado esperado en consola
    Nombre: Juan, Apellido: Perez
    Nombre: Pedro, Apellido: Paez
    True

- Primero muestra los datos iniciales.

- Luego cambia el nombre y apellido.

- Después muestra los datos modificados.

- El True confirma que persona1 y persona2 son el mismo objeto en memoria.
