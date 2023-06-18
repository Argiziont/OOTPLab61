---------------------------------------English

Develop a technical task. Show the decomposition of the task, where some of the tasks should be implemented using generating patterns:
- Interpreter. 
- Mediator.  

Terms of reference.

The technical task: Report generator
A tool is required that can generate reports in various formats (PDF, CSV, Excel), based on various filters and sorting criteria. The system should be able to handle large data sets and be scalable. 

Requirements:
- The report generator must be implemented in C#.

- The generator should be developed using the Interpreter and Mediator templates.

- The system should allow the user to choose the report format (PDF, CSV, Excel).

- The system should allow the user to select data to be included in the report based on various filters (e.g., date range, customer name, product category).

- The system should allow the user to sort the data in the report based on various criteria (e.g., product name, order quantity).

- The system should be able to handle large data sets and be scalable. 

Deliverables:
- C# code that implements the report generator using Interpreter and Mediator.
- Unit tests that check the functionality of the report generator.

The interpreter template will be used to analyze and interpret user-selected filters and sorting criteria. This will allow us to create a flexible and extensible system that can handle a variety of filtering and sorting parameters.

The Mediator template will be used to handle the communication between different components of the system (for example, the user interface, the reporting engine, and the data storage layer). This will allow us to separate the components and make the system more modular and easier to maintain.

Overall, the use of these two patterns will help us create a robust and scalable report generation system that can handle large data sets and be customized to meet the needs of different users.
---------------------------------------Українська

Розробити технічне завдання. Показати декомпонування завдання, де частина завдань має бути реалізована з використанням породжуючих патернів:
-	Інтерпретатор (Interpreter). 
-	Посередник (Mediator).  

Технічне завдання

Технічне завдання: Генератор репортів
Потрібен інструмент, який може генерувати звіти в різних форматах (PDF, CSV, Excel), на основі різних фільтрів і критеріїв сортування. Система повинна мати можливість обробляти великі набори даних і бути масштабованою. 
Вимоги:
•	Генератор звітів повинен бути реалізований на C#.

•	Генератор має бути розроблений за допомогою шаблонів Interpreter і Mediator.

•	Система повинна дозволяти користувачеві вибрати формат звіту (PDF, CSV, Excel).

•	Система повинна дозволяти користувачеві вибирати дані для включення у звіт на основі різних фільтрів (наприклад, діапазон дат, ім’я клієнта, категорія продукту).

•	Система повинна дозволяти користувачеві сортувати дані у звіті на основі різних критеріїв (наприклад, назва продукту, кількість замовлення).

•	Система повинна мати можливість обробляти великі набори даних і бути масштабованою. 

Результати роботи:
•	Код C#, який реалізує генератор звітів за допомогою Interpreter і Mediator.

•	Модульні тести, які перевіряють функціональність генератора звітів.

Шаблон інтерпретатора буде використовуватися для аналізу та інтерпретації вибраних користувачем фільтрів і критеріїв сортування. Це дозволить нам створити гнучку та розширювану систему, яка зможе працювати з різноманітними параметрами фільтрації та сортування.

Шаблон Mediator використовуватиметься для обробки зв’язку між різними компонентами системи (наприклад, інтерфейсом користувача, механізмом створення звітів і рівнем зберігання даних). Це дозволить нам розділити компоненти та зробити систему більш модульною та простішою в обслуговуванні.

Загалом, використання цих двох шаблонів допоможе нам створити надійну та масштабовану систему генерації звітів, яка може обробляти великі набори даних і налаштовуватися відповідно до потреб різних користувачів.
