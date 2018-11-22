select top 100 p.FirstName, p.LastName, e.HireDate from HumanResources.Employee e
left join Person.Person p on e.BusinessEntityID = p.BusinessEntityID

insert into WarehouseManager.dbo.Employee(FirstName, LastName)
select x.imie, x.nazwisko
from ( select top 100 p.FirstName imie, p.LastName nazwisko, e.HireDate data_zatrudnienia from HumanResources.Employee e
left join Person.Person p on e.BusinessEntityID = p.BusinessEntityID
order by e.HireDate desc) x
