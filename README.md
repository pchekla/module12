# module12

https://github.com/pchekla/module12

## Объяснение кода
В Main() создаётся список пользователей с разными значениями IsPremium.
Метод GreetUsers() принимает этот список и выполняет итерацию по каждому пользователю.
Для каждого пользователя выводится приветствие с его именем.
Если у пользователя нет премиум-подписки, вызывается метод ShowAds(), чтобы показать рекламу.
Метод ShowAds() выводит рекламные сообщения с паузами между ними.
Вывод
При запуске программы каждый пользователь получает приветствие, и для пользователей без премиум-подписки отображается реклама.

## Алгоритм работы программы


```mermaid
flowchart TD
    A([Начало])
    A --> B[/Создать список пользователей и заполнить его/]
    B --> C["Вызвать метод GreetUsers(users)"]
    C --> D{{Перебрать каждого пользователя в списке}}
    F ---- Да ----> D
    D --> E[/"Вывести приветствие с именем пользователя: Hello, {user.Name}"/]
    E --> F{Пользователь имеет премиум-подписку?}
    F -- Нет --> G["Вызвать метод ShowAds()"]
    G --> H[/Вывести рекламные сообщения/]
    H --> I
    D ----------> I([Конец])