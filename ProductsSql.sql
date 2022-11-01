Судя по описанию, есть таблицы Products(продукты) и Categories(категории). Также по описанию связь между ними многие ко многим, то есть предполагаю что должна быть таблица ProductCategories, у которой есть стобец ProductId, со ключом из таблицы Products и столбец CategoryId с ключом из таблицы Categories.
Тогда запрос получится такой:

SELECT p.Name, c.Name
FROM Products p
LEFT JOIN ProductCategories pc ON p.Id = pc.ProductId
LEFT JOIN Categories c on pc.CategoryId = c.Id

Не совсем понятно по описанию нужно ли выводить категории, у которых нет продуктов. Предположил что не нужно, так как в постановке явно указано только что нужно выводить продукты у которых нет категории