![image](https://github.com/user-attachments/assets/ec51183e-20d8-4a3a-9b33-4a2a91b71738)

Внимание! Этот проект создан исключительно для образовательных и развлекательных целей. Он демонстрирует, как может быть организован доступ к данным в IL2CPP играх. Использование в целях читерства категорически не приветствуется и, как правило, запрещено правилами игр.

▌Описание

Этот проект - это учебный пример, показывающий базовые принципы манипулирования данными в играх, построенных на IL2CPP (Intermediate Language To C++). Он демонстрирует, как можно теоретически получить доступ к внутренним переменным и функциям игры, для, например, изменения значений здоровья, количества игровой валюты и т.д.

Ключевое слово – "демонстрирует". Этот проект не является готовым к использованию читом. Это фундамент, который можно использовать для изучения и экспериментов с IL2CPP, с этической и законной целью – расширение своих знаний.

▌Цель проекта

• Обучение: Предоставить отправную точку для изучения IL2CPP и методов работы с памятью игры.
• Эксперименты: Позволить безопасное и законное экспериментирование с модификацией данных в расте.
• Развлечение: Показать возможности и ограничения, связанные с модификацией IL2CPP игр в контролируемой среде.

▌Функциональность (Принципиальная)

Проект в теории позволяет:

• Поиск: Находить игровые объекты и функции в памяти.
• Чтение/Запись: Читать и изменять значения переменных.
• Вызов функций: Вызывать функции внутри игры.
• Работа с IL2CPP: Использовать специфичные для IL2CPP методы для доступа к данным.

Важно: Функциональность проекта требует значительной адаптации и настройки для работы с конкретной игрой. Это не универсальное решение "из коробки".

▌Установка и использование

1. Клонирование репозитория: Получите код проекта.

2. Компиляция: Скомпилируйте проект в DLL (библиотеку).

3. Внедрение: Интегрируйте DLL в целевую игру (закинуть файл .dll в путь BepInEx/plugins).

4. Настройка: Адаптируйте код для работы с конкретной игрой, определяя адреса и структуры данных.
5. Использование: Зайдите на сервер и нажмите клавишу n, в консоли пропишет Simmoni Activated!
6. Команды: Для включения вх в консоль пропишите следующие команды: culling.debug 1 / culling.entityupdaterate 244 А так же вам доступен весь спектр функционала Admin(Noclip не включайте, иначе сразу же забанит)

▌Зависимости

• C# компилятор: Необходим для компиляции кода.
• BepInEx: Необходим для внедрения плагина.
• Interop и Core библиотеки сдампленные с помощью BepInEx (BepInEx/core & BepInEx/interop)
• .NET Framework 4.7.2

▌Вклад

Приветствуется вклад в виде предложений, улучшений и документации.
