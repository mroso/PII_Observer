# Universidad Católica del Uruguay
## Facultad de Ingeniería y Tecnologías
### Programación II
Código de ejemplo del patrón [Observer](https://en.wikipedia.org/wiki/Observer_pattern)

El ejemplo consiste esencialmente de tres clases:
* Temperature
* TemperatureMonitor
* TemperatureReporter

### Temperature
Representa una lectura de un sensor de temperatura

| Responsabilidades | Colaboraciones |
|-------------------|----------------|
| Conocer una lectura de temperatura ||
| Conocer la fecha y hora en que se leyó la temperatura ||

### TemperatureMonitor
Representa un sensor de temperatura

| Responsabilidades | Colaboraciones |
|-------------------|----------------|
| Conocer la temperatura actual | Temperature |
| Conocer los reportadores interesados en la temperatura actual | TemperatureReporter |
| Agregar un reportador interesado ||
| Remover un reportador previamente agregado ||

### TemperatureReporter
Representa un dispositivo capaz de mostrar valores (por ejemplo un display de siete segmentos o un monitor)

| Responsabilidades | Colaboraciones |
|-------------------|----------------|
| Conectarse a un monitor de temperatura | TemperatureMonitor |
| Desconectarse de un monitor de tempratura ||
| Recibir actualizaciones del monitor de temperatura ||

### Diagramas
A continuación mostramos esas clases en un diagrama:
![Diagrama de clases](https://github.com/ucudal/PII_Observer_Start/blob/master/images/Observer-Clases.svg?sanitize=true)

Este es un diagrama de los mensajes intercambiados entre las clases:
