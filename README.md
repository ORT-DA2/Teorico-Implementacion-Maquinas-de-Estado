# Teórico: Implementación de Máquinas de Estado

![Turnstile](https://github.com/ORT-DA2/Teorico-Implementacion-Maquinas-de-Estado/blob/master/imagenes/turnstile.jpg)

Ejemplos de implementaciones de máquinas de estado, tomando en cuenta el caso de una máquina de estado para modelar el *turnstile* (molinete).

La máquina a implementar sigue la siguiente representación en UML:

![Diagrama](https://github.com/ORT-DA2/Teorico-Implementacion-Maquinas-de-Estado/blob/master/imagenes/maquina-diagrama.png)

Representación tabular:

State / Next State | Destrancado | Inicial | Trancado
------------ | ------------- | ------------- | -------------
Destrancado | Moneda / Muchas gracias | - | Pasar / Trancar
Inicial | - | - | -
Trancado | Moneda / Destrancar | - | Pasar / Sonar Alarma

State / Trigger | Moneda | Pasar | None
------------ | ------------- | ------------- | -------------
Destrancado S0 | S0 | S2 | -
Inicial S1  | - | - | S2
Trancado S2 | S0 | S2 | -

Ver las implementaciones brindadas en el código fuente del repositorio.



