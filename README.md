# Design-patterns-hw3
Домашнее задание 3 по курсу Паттерны и шаблоны проектирование.

## Формулировка задания
Необходимо реализовать Builder для электронных писем:
 1. Обязателен хотя бы один получатель
 2. Обязательно тело письма
 3. Есть возможность добавить получателей копии
 4. Есть возможность добавить тему
 
## Описание решения задания:
В конечном результате получился гибрид State (state builder, но википедия знает только 
[state pattern](https://en.wikipedia.org/wiki/State_pattern)) и Fluent interface (fluent builder, но опять же, википедия знает только
[fluent interface](https://ru.wikipedia.org/wiki/Fluent_interface). Соответственно 1, 2 и 4 пунктов использовался state, а для 3 
fluent interface

## Вопросы
Не могу понять, чем существенно отличаются Builder от Abstract factory
