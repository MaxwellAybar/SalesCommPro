# SalesCommPro

Aplicación web para calcular comisiones de ventas según el país de operación del vendedor. Desarrollada con arquitectura en capas usando ASP.NET Core MVC.

---

## Descripción

Esta herramienta permite a los vendedores calcular de forma rápida su comisión mensual ingresando sus ventas totales, descuentos aplicados y el país donde operan.

El sistema aplica automáticamente la tasa de comisión correspondiente a cada país, proporcionando resultados claros y confiables.

---

## Reglas de negocio

| País            | Tasa de comisión | Fórmula                          |
|-----------------|------------------|----------------------------------|
| India           | 10%              | (Ventas - Descuentos) × 0.10     |
| Estados Unidos  | 15%              | (Ventas - Descuentos) × 0.15     |
| Reino Unido     | 12%              | (Ventas - Descuentos) × 0.12     |

---

## Arquitectura en capas

El proyecto está organizado en 4 proyectos que representan la separación de responsabilidades:

```text
SalesCommPro/
├── SalesCommPro.Web            <-- Interfaz de Usuario (ASP.NET Core MVC)
├── SalesCommPro.Application    <-- Objetos de Transferencia de Datos (DTOs)
├── SalesCommPro.Domain         <-- Entidades y Reglas del Negocio
└── SalesCommPro.Infrastructure <-- Lógica de Cálculo y Servicios


---

## Capa de presentación

Contiene la aplicación web ASP.NET MVC que el usuario visualiza e interactúa:

- Controllers  
- Views (Razor)  
- Models  

---

## Capa de lógica de negocio

Contiene el servicio principal:

- CommissionService  

Responsable de aplicar la fórmula:

(Ventas - Descuentos) × Tasa

---

## Capa de datos

Contiene las entidades del dominio:

- Commission  

En este proyecto no se utiliza base de datos, ya que las reglas son estáticas.

---

## Tecnologías

- ASP.NET Core MVC (.NET 8)  
- C#  
- Razor Views  
- Bootstrap 5  

---

## Instalación y ejecución local

### Requisitos previos

- .NET 8 SDK  
- Visual Studio 2022 o superior  

---

### Pasos

1. Clonar el repositorio

git clone https://github.com/MaxwellAybar/SalesCommPro.git

cd SalesCommPro

2. Abrir la solución en Visual Studio  

3. Establecer como proyecto de inicio:


SalesCommPro.Web


4. Ejecutar el proyecto (F5)

---

## Uso

1. Ingresar:
   - Ventas totales  
   - Descuentos  
   - País  

2. Presionar el botón "Calcular"  

3. El sistema mostrará la comisión calculada automáticamente  

---

## Ejemplo

Ventas: 1000  
Descuento: 100  
País: US  

Resultado: **135**

---

## Autor

Maxwell Aybar  2024 2150
Proyecto académico — Programación II  
Instituto Tecnológico de Las Américas (ITLA)
