# Simulador Liga BetPlay en Consola (C#)

## Descripción

Este proyecto consiste en una aplicación de consola desarrollada en **C#** que permite simular el funcionamiento básico de la **Liga BetPlay**.

El programa permite:

- Registrar equipos
- Simular partidos manualmente
- Calcular estadísticas automáticamente
- Mostrar tabla de posiciones
- Consultar información del torneo usando LINQ

El objetivo del proyecto es practicar:

- Programación Orientada a Objetos (POO)
- Uso de listas en memoria
- Métodos
- LINQ básico
- Organización modular del código
- Lógica de programación

---

## Características principales

El sistema permite:

- Crear equipos
- Guardar estadísticas de cada equipo
- Simular partidos introduciendo los goles manualmente
- Calcular puntos automáticamente
- Mostrar tabla de posiciones ordenada
- Realizar consultas sobre el torneo
- Navegar mediante menú en consola

---

## Estructura del proyecto

```
LigaBetPlay
│
├── Program.cs
│
├── Modelos
│ └── Equipo.cs
│
├── Servicios
│ ├── Torneo.cs
│ ├── SimuladorPartidos.cs
│ └── Consultas.cs
│
└── Utilidades
└── Menu.cs
```

---

## Clases principales

### Equipo
Representa un equipo de fútbol y sus estadísticas:

- Nombre
- Partidos jugados
- Partidos ganados
- Empates
- Derrotas
- Goles a favor
- Goles en contra
- Puntos

---

### Torneo
Administra la lista de equipos.

Funciones:

- Registrar equipos
- Listar equipos
- Buscar equipos

---

### SimuladorPartidos
Permite ingresar los goles manualmente y actualiza las estadísticas.

---

### Consultas
Contiene consultas usando LINQ:

- Líder del torneo
- Top 3
- Equipos invictos
- Equipos sin victorias
- Promedios de goles
- Total de puntos
- Diferencia de gol positiva
- Equipos con más goles
- Tabla ordenada
- Resumen del torneo
- Orden alfabético

---

### Menu
Controla la interacción con el usuario mediante consola.

Incluye:

- Menú principal
- Submenú de consultas
- Validación de datos con TryParse

---

## Requisitos

- .NET SDK instalado
- Visual Studio o Visual Studio Code

---

## Cómo ejecutar el proyecto

1. Crear el proyecto de consola


dotnet new console


2. Copiar los archivos en sus respectivas carpetas

3. Ejecutar el programa


dotnet run


---

## Uso del programa

### Menú principal

1. Registrar equipo
2. Listar equipos
3. Simular partido manual
4. Mostrar tabla de posiciones
5. Consultas del torneo
6. Salir

---

### Submenú de consultas

Permite consultar información como:

- Líder del torneo
- Equipos con más goles
- Equipos con menos goles recibidos
- Top 3
- Promedios
- Equipos invictos
- Equipos ordenados alfabéticamente
- Resumen general

---

## Ejemplo de uso

Registrar equipos:


Nacional
Junior
Millonarios
America


Simular partido:


Nacional 2 - 1 Junior


Mostrar tabla:


Nacional 3 pts
Junior 0 pts


---

## Tecnologías utilizadas

- Lenguaje: C#
- Tipo de aplicación: Consola
- Paradigma: Programación Orientada a Objetos
- Estructura de datos: List
- Consultas: LINQ

---

## Objetivo académico

Este proyecto fue desarrollado con fines educativos para practicar:

- lógica de programación
- estructura de proyectos
- uso de clases
- manipulación de listas
- consultas con LINQ

---

## Posibles mejoras futuras

- Generar calendario automático de partidos
- Guardar datos en archivos
- Base de datos
- Interfaz gráfica
- Estadísticas avanzadas
- Goleadores individuales

---

## Autor: Danny Julian Velasco Olarte

Proyecto académico desarrollado por estudiante de programación en C#.