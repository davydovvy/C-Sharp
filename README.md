
## СОГЛАШЕНИЕ ОБ ИНТЕГРАЦИИ (МЕЖСИСТЕМНАЯ ИНТЕГРАЦИЯ)

### АВТОМАТИЗИРОВАННАЯ СИСТЕМА УПРАВЛЕНИЯ ПЕРСОНАЛОМ (АСУП)

### ИНФОРМАЦИОННАЯ СИСТЕМА ПО РАБОТЕ С ПРЕДЛОЖЕНИЯМИ СОТРУДНИКОВ ПО УЛУЧШЕНИЯМ (СИСТЕМА «4И»)

## Глоссарий
|Сокращение|Расшифровка|
|----------|-----------|
|АСУП|Автоматизированная система управления персоналом|
|БД|База данных|
|ИС|Информационная система|
|Система 4И|Программа для ЭВМ «4И версия 3.0» (свидетельство о государственной регистрации № 2018662786 от «16» октября 2018 г) на базе которой создается ИС по работе с предложениями сотрудников по улучшениям. Представляет собой программный комплекс, состоящий из web-приложений, и сервисных windows приложений.|

## Краткое описание интегрируемых систем
### Автоматизированная система управления персоналом (АСУП)
АСУП предназначена для автоматизации задач, связанных с централизованным расчетом заработной платы персонала и реализаций кадровой политики, с учётом требований законодательства и реальной практики работы компаний. АСУП успешно применяется в службах управления персоналом и бухгалтериях предприятий, а также в других подразделениях, заинтересованных в эффективной организации работы сотрудников, для управления человеческими ресурсами.

Функциональные возможности АСУП:
* Учёт кадров и персонифицированный учёт;
* Расчёт заработной платы;
* Формирование оценочных обязательств (резервов) отпусков;
* Выплаты и депонирование;
* Исчисление НДФЛ и страховых взносов;
* Подготовка регламентированной отчётности;
* Грейды и KПЭ;

### Система 4И
Информационная система по работе с предложениями сотрудников по улучшениям, созданная на базе программы для ЭВМ «4И версия 3.0». Представляет собой программный комплекс, состоящий из web-приложений, и сервисных windows приложений.

Основные функциональные возможности ИС по работе с предложениями сотрудников по улучшениям:
* Сбор предложений сотрудников, подаваемых как по запросу, так и в инициативном порядке;
* Размещение запросов руководства предприятия на решение актуальных проблем;
* Коллективное обсуждение предложений и расчет параметра «Значимость» предложения;
* Поддержка экспертизы предложений (рассылка заданий экспертам, подготовка и сбор заключений, контроль соблюдения сроков);

## ЦЕЛИ И ЗАДАЧИ ИНТЕГРАЦИИ
Основной целью интеграции систем «4И» и АСУП является:
* Автоматизированная актуализация в системе «4И» справочников, используемых для отображения оргструктуры Заказчика;
* Автоматизированная актуализация данных профиля пользователя в системе «4И»;
* Определение непосредственного руководителя сотрудника.

|Наименование потока|Объект системы-отправителя|Система-отправитель|Система-приемник|Объект-источник системы-приемника|Инициирующее событие|Способ интеграции|
|------|-----|-----|-----|----|------|----|
|Организационная структура|Изменения в справочнике "Подразделения организации"|АСУП|Система 4И|
Промежуточные таблицы БД системы 4И|Периодическое выполнение запроса по настроенному расписанию в АСУП|Запись в промежуточные таблицы БД системы 4И|
|Организационная структура|Изменения в справочнике "Подразделения организации"|АСУП|Система 4И|Промежуточные таблицы БД системы 4И|Периодическое выполнение запроса по настроенному расписанию в АСУП|Запись в промежуточные таблицы БД системы 4И|
|Организационная структура|Изменения в справочнике "Подразделения организации"|АСУП|Система 4И|Промежуточные таблицы БД системы 4И|Периодическое выполнение запроса по настроенному расписанию в АСУП|Запись в промежуточные таблицы БД системы 4И|