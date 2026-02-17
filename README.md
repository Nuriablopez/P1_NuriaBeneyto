Este proyecto es un juego de plataformas que se ha creado en Unity. El propósito fundamental es sobrepasar un circuito conformado por varias plataformas, algunas de ellas móviles o con comportamiento dinámico, hasta que se termine el recorrido.

El circuito principal fue lo primero que se creó:

Como punto de partida del mapa, se desarrolló el suelo (en color verde).
Se crearon e instalaron varias plataformas a lo largo de la ruta (la mayoría duplicadas).
Algunas plataformas se desplazan, mientras que otras se caen.
Las plataformas tienen un Box Colaider para las colisiones.

El personaje fue diseñado con:

Capsule Collider, con el objetivo de optimizar las colisiones y prevenir conductas raras al golpear esquinas.
Sistema de físicas apropiado para que interactúe adecuadamente con el entorno.
Un controlador de animación, en el cual se distribuyeron y enlazaron las distintas acciones (caminar, saltar, caer, etc.).
Las transiciones entre las animaciones se ajustaron de manera apropiada para que reaccionen al estado del personaje (caída, salto, movimiento, etc.).
Tiene Rigidbody para que interactúe de forma correcta con el entorno.

Se desarrollaron varios scripts personalizados para controlar la lógica del juego:

El script principal del jugador se encarga de:
Desplazamiento lateral.
Salto.
Aumento de velocidad.
Interacción con el entorno.
Manejo de estados para la animación.

Se programaron plataformas que se desplazan automáticamente siguiendo un patrón definido. Además se añadió un destino para que no se vaya la plataforma.

Algunas plataformas reaccionan cuando el jugador interactúa con ellas (en este caso, caen).

Se bajaron personajes adicionales en Kenney para marcar de manera clara el final del recorrido. Estos fueron ubicados en la plataforma terminal del circuito.
