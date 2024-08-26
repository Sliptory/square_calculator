# SQL-Test
### Задание:
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

## Data Model
|Products        |
|----------------|
|+Id : INT       |
|+name: VARCHAR  |

|Categories      |
|----------------|
|+Id : INT       |
|+name: VARCHAR  |

|ProdCat               |
|----------------------|
|+Id : INT             |
|+product_id : VARCHAR |
|+category_id: VARCHAR |

### Ответ:
```sql
SELECT Products.name AS Product_Name, Categories.name AS Category_Name
FROM ProdCat
JOIN Products
    ON ProdCat.product_id = Products.Id
LEFT JOIN Categories
    ON ProdCat.category_id = Categories.Id
```
