# OpenClosed

- Un módulo o clase de un software solo debe estar abierto para su extensión pero cerrado para su modificación.

## Separamos la logica de envío de notificaciones en distintas clases que implementan una interfaz comun, para evitar 
que notificationService tenga que implementar una funcionalidad particular cada vez que se agrega un tipo de notificación. 
