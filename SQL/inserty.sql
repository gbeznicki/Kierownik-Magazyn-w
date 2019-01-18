select top 20 p.FirstName, p.LastName, e.HireDate from HumanResources.Employee e
left join Person.Person p on e.BusinessEntityID = p.BusinessEntityID

insert into WarehouseManager.dbo.Employee(FirstName, LastName)
select top 20 x.imie, x.nazwisko
from ( select top 100 p.FirstName imie, p.LastName nazwisko, e.HireDate data_zatrudnienia from HumanResources.Employee e
left join Person.Person p on e.BusinessEntityID = p.BusinessEntityID
order by e.HireDate desc) x


drop table #Tab
select top 20 e.HireDate, 
into #Tab
from HumanResources.Employee e

declare @HireDate date, @id int
set @id = 1

declare testCursor cursor for
select top 20 e.HireDate from HumanResources.Employee e

open testCursor

Fetch next from testCursor
into @HireDate

While @@FETCH_STATUS = 0
begin
	insert into WarehouseManager.dbo.EmployeeDetails (HireDate, EmployeeId)
	values(@HireDate, @id)

	set @id += 1

	fetch next from testCursor
	into @HireDate
end

close testCursor
deallocate testCursor