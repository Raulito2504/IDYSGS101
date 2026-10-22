# Prácticas de Unity — Desarrollo de Videojuegos

Este repositorio reúne las prácticas de introducción al Unity Editor, objetos y componentes, programación en C#, física 2D y sistema de entrada del jugador.

Las actividades están organizadas por escenas. Algunas comparten una misma escena porque se desarrollaron de forma progresiva sobre el mismo ejercicio. La siguiente relación permite localizar cada práctica dentro del proyecto.

## Relación de actividades y escenas

| N.º | Actividad                                                         | Escena                                                                       | Observaciones                                                                                    |
| --- | ----------------------------------------------------------------- | ---------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------ |
| 1   | SampleScene — Objetos simples                                     | [SampleScene.unity](Assets/Scenes/SampleScene.unity)                         | Práctica inicial con objetos simples y triángulos.                                               |
| 2   | Scene 1 — Físicas básicas                                         | [Scene0.unity](Assets/Scenes/Scene0.unity)                                   | El nombre de la actividad es «Scene 1», pero el archivo correspondiente es `Scene0.unity`.       |
| 3   | Plinko                                                            | [Plinko.unity](Assets/Scenes/Plinko.unity)                                   | Escena del ejercicio de Plinko.                                                                  |
| 4   | Script de movimiento básico                                       | [Scene2.unity](Assets/Scenes/Scene2.unity)                                   | Base de los ejercicios de movimiento que se integran en esta misma escena.                       |
| 5   | Clase 3 — Actividad 1                                             | [Scene1.unity](Assets/Scenes/Scene1.unity)                                   | Escena correspondiente a la actividad de GameObjects, Transform y componentes.                   |
| 6   | Nave                                                              | [Nave.unity](Assets/Scenes/Nave.unity)                                       | Práctica de movimiento de una nave mediante fuerzas.                                             |
| 7   | Clase 4 — Actividad 1: movimiento con flechas                     | [Scene2.unity](Assets/Scenes/Scene2.unity)                                   | Comparte escena y script de movimiento con las actividades 4 y 8 de esta tabla.                  |
| 8   | Clase 4 — Actividad 2: cambiar las teclas                         | [Scene2.unity](Assets/Scenes/Scene2.unity)                                   | Integra el uso de WASD junto con las flechas de dirección.                                       |
| 9   | Clase 5 — Ejercicio 1: movimiento directo con Transform           | [Escena01_Transform.unity](Assets/Scenes/Escena01_Transform.unity)           | Ejercicio de desplazamiento directo mediante Transform.                                          |
| 10  | Clase 5 — Ejercicio 2: impulsos y fuerzas con Rigidbody2D         | [Escena02_AddForce.unity](Assets/Scenes/Escena02_AddForce.unity)             | Ejercicio de aplicación de impulsos con Rigidbody2D.                                             |
| 11  | Clase 5 — Ejercicio 3: velocidad, gravedad y colisiones           | [Escena03_LinearVelocity.unity](Assets/Scenes/Escena03_LinearVelocity.unity) | Ejercicio de velocidad inicial e interacción física con una plataforma.                          |
| 12  | Clase 6 — Ejercicio 1: configurar las acciones de entrada         | [Escena01_InputMovement.unity](Assets/Scenes/Escena01_InputMovement.unity)   | La configuración de acciones se utiliza en el personaje del ejercicio 2; ambos comparten escena. |
| 13  | Clase 6 — Ejercicio 2: mover un personaje con el New Input System | [Escena01_InputMovement.unity](Assets/Scenes/Escena01_InputMovement.unity)   | Integra la configuración del ejercicio 1 con el movimiento del personaje.                        |
| 14  | Clase 6 — Ejercicio 3: fuerzas, impulso y cambio de color         | [Escena02_InputPhysics.unity](Assets/Scenes/Escena02_InputPhysics.unity)     | Integra acciones de entrada con movimiento físico, impulso y cambio de color.                    |
| 15  | Clase 6 — Reto final: migrar la nave de equilibrio                | [Reto_Input_Equilibrio.unity](Assets/Scenes/Reto_Input_Equilibrio.unity)     | Escena de la migración al New Input System.                                                      |

## Actividades que comparten escena

### Movimiento básico y actividades de la clase 4

`Scene2.unity` reúne el script de movimiento básico, el movimiento con flechas y la incorporación de teclas WASD. Estas prácticas se trabajaron sobre el mismo objeto y script, por lo que su resultado se encuentra integrado en una sola escena.

### Configuración de entrada y movimiento de la clase 6

Los ejercicios 1 y 2 de la clase 6 se encuentran en `Escena01_InputMovement.unity`. El primer ejercicio configura las acciones de entrada y el segundo utiliza esa configuración para mover al personaje.

El archivo de acciones compartido es [PlayerControls.inputactions](Assets/Settings/PlayerControls.inputactions).
