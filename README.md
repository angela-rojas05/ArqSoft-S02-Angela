# 🐍 Juego Viborita

## 📌 Datos institucionales

- **Universidad:** Tecnologico de Software
- **Materia:** Arquitectura de Software
- **Proyecto:** Juego Viborita en Consola
- **Alumno:** Angela Yaritzi Rojas Brito
- **Grupo:** 3B
- **Profesor:** Jorge Javier Pedrozo Romero
- **Fecha:** 15/05/26

---

# 📖 Descripción del proyecto

Este proyecto consiste en el desarrollo de un juego tipo Snake en consola utilizando C# y .NET. El jugador controla una víbora que debe recolectar comida para aumentar su tamaño, evitando chocar con las paredes o consigo misma.

El proyecto fue desarrollado utilizando separación de responsabilidades para mantener una arquitectura más organizada y escalable en este caso. 

---

# 🛠️ Tecnologías usadas

- C#
- .NET
- Consola de Windows

---

# ⚙️ ¿Qué se realizó?

- Movimiento dinámico de la víbora
- Sistema de crecimiento
- Generación aleatoria de comida
- Detección de colisiones
- Sistema de puntos
- Condición de victoria y derrota
- Interfaz visual en consola
- Personalización de colores del tablero

---

# ▶️ ¿Cómo funciona?

1. El jugador controla la víbora usando las flechas del teclado.
2. La víbora avanza automáticamente.
3. Al comer alimento, aumenta el puntaje y el tamaño.
4. El juego termina si la víbora choca con una pared o consigo misma.
5. El jugador gana al alcanzar 10 puntos.

---

# 🧠 Principios SOLID aplicados

Durante el desarrollo del proyecto se aplicaron principios SOLID para mejorar la organización y mantenimiento del código.

- **SRP (Single Responsibility Principle):**  
  `MotorViborita` maneja la lógica del juego y `ConsolaUIViborita` la visualización.

- **OCP (Open/Closed Principle):**  
  Fue posible agregar personalización visual sin modificar la lógica principal.

- **DIP (Dependency Inversion Principle):**  
  Se utilizó la interfaz `IMotorJuego` para separar comportamientos del juego.

---


# 📷 Capturas de pantalla


---

# 🤖 Cláusula de IA

Durante el desarrollo de este proyecto se utilizaron herramientas de inteligencia artificial (ChatGPT) como apoyo para resolver dudas técnicas y mejorar la parte visual del juego Y correciones pequeñas en unas cuantas lineas de codigo, principalmente al incializar un objeto. 

---

# 🚀 Ejecución del proyecto

1. Clonar el repositorio
2. Abrir el proyecto en Visual Studio
3. Ejecutar el archivo `Program.cs`
4. Seleccionar la opción Viborita desde el menú principal

---

# 📂 Contacto

- Hecho por: Ángela Yaritzi Rojas Brito
- Correo: angela.rojas@tecdesoftware.edu.mx
