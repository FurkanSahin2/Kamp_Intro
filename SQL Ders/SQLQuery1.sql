-- Overdesign, aşırı tasarım demektir. Bu şey yönetilebilir olmadığından dolayı olumsuz bir durumdur. 
-- Select, bir veri kaynağındaki data'yı çekmeye yarar.
-- ANSII

Select ContactName Adi,CompanyName ŞirketAdi,City Sehir from Customers 

Select * from Customers where City = 'London' -- buradaki * ifadesi bütün kolonlar manasına gelmektedir.

-- Sql --> case insensitive  = büyük / küçük harf duyarsızdır.
-- where, koşul için kullanılır.

sElEcT * from Products where CategoryID = 1 or CategoryID = 3	

select * from Products where CategoryID = 1 and UnitPrice >= 10 

-- order by, sırala manasına gelmektedir.

select * from Products where CategoryID=1 order by UnitPrice desc    -- order by'ın default'u asc: ascending => artan ; desc: descending => azalan

-- Count, adet demek olup aşağıdaki komut, tüm satırların adedini ver demektir.

select count(*) Adet from Products where CategoryID=1

-- group by, datayı ... 'ya göre grupla demektir. 
-- group by'larda kümülatif dataya yazılan koşul => having. Bu keyword koşul ifade eder. Yani, datayı filtrelemek istersek => where; listeyi filtrelemek istersek => having kullanırız.

select CategoryID, COUNT(*) Ürün from Products where UnitPrice>20 group by CategoryID having count(*)<10

-- inner join, bir araya getir manasındadır. on, durumunda/ şartında manasına gelmektedir. 

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName, Products.UnitPrice from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

-- DTA => Data Transformation Object

-- inner join, sadece iki tabloda da eşleşenleri bir araya getirir. Eşleşmeyen data varsa onları getirmez. 
-- left join, 'solda olup sağda olmayanları da getir' demektir.

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID


Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

-- Örneğin, sisteme kaydolmuş ancak henüz alışveriş yapmamış olanları sıralamak istersek aşağıdaki kodu yazabiliriz. Çünkü 'solda olup sağda olmayanları da yaz diyince' eşleşme sonucu verilen datalardan (830) iki artmıştır. (832) 

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

-- right join, 'sağda olup solda olmayanları da getir' demektir. (Çok kullanışlı değildir)

select * from Orders o right join Customers c
on c.CustomerID = o.CustomerID
where o.CustomerID is null

-- ikiden fazla tabloyu 'join' etmek için;

Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID




