# Proyecto: Sistema de Locomoción 3D y Cámara Dinámica
**Materia:** Programación Grafica y Multimedia II
---

## Descripción del Proyecto
Este proyecto consiste en la implementación técnica de un sistema de control de personaje en tercera persona dentro del motor **Unity**. Se enfoca en la creación de una arquitectura de software limpia y escalable, utilizando componentes nativos del motor y herramientas avanzadas de gestión de cámara.

## Etapa 1: Fundamentos y Locomoción
En esta primera fase se han cumplido los siguientes hitos técnicos requeridos por la guía del proyecto:

### 1. Configuración de Escena y Entorno
*   **Gestión de Colisiones:** Creación de un entorno base con un `Plane` configurado como suelo y un `Player` temporal (Cylinder).
*   **Tags y Layers:** Implementación de capas de usuario para una correcta interacción física y filtrado de cámaras.

### 2. Sistema de Locomoción Fluida
*   **Character Controller:** Uso de este componente para gestionar el movimiento basado en colisiones y pendientes de forma nativa.
*   **Script de Movimiento:** Desarrollo del script `PlayerMovement.cs` que permite:
    *   Movimiento relativo a la orientación de la cámara.
    *   Rotación suave mediante interpolación angular (`Mathf.SmoothDampAngle`).
    *   Cálculo de dirección normalizada para evitar velocidad excesiva en diagonales.

### 3. Cinemachine y Cámara Dinámica
*   **FreeLook Camera:** Implementación de una cámara inteligente que orbita al jugador.
*   **Evitación de Obstáculos:** Configuración de la extensión `Cinemachine Collider` para prevenir que la cámara atraviese la geometría del nivel.

## Optimización y Control de Versiones
*   **Optimización de Repositorio:** Implementación de un archivo `.gitignore` personalizado para Unity, excluyendo archivos de caché y metadatos temporales (Library, Temp), reduciendo el peso del repositorio en un 99%.
*   **Flujo de Trabajo:** Uso de **GitHub Desktop** y comandos de terminal Git para el seguimiento de versiones y commits descriptivos.

## Instrucciones de Uso
1.  Clonar el repositorio en una carpeta local.
2.  Abrir el proyecto con **Unity 2022.3 LTS** (o superior).
3.  Asegurarse de que el paquete **Cinemachine** esté instalado desde el *Package Manager*.
4.  Presionar **Play** y utilizar las teclas `W`, `A`, `S`, `D` para mover al personaje y el `Mouse` para controlar la vista.

---
*Este proyecto es parte de la evaluación continua de la asignatura de Programación de Videojuegos.*
