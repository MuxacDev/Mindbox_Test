use MindboxDb
select p.name as 'Имя продукта',c.name as 'Имя категории'
from dbo.Products p 
left join dbo.Categories c 
on c.id=p.category_id or p.id=c.product_id