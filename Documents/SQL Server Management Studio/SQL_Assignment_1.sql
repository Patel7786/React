--1
select Count(*) from [Sales].[SalesPerson];
--2
select firstname ,lastname from [Person].[Person] where FirstName like 'B%';



--3
select pp.firstname ,pp.lastname,HRE.JobTitle
from Person.Person as pp INNER JOIN HumanResources.Employee as HRE ON pp.BusinessEntityID = HRE.BusinessEntityID
where ((HRE.JobTitle='Design Engineer') OR
(HRE.JobTitle ='Tool Designer') OR 
(HRE.JobTitle='Marketing Assistant')) ;



select count(JobTitle) ,JobTitle
from [HumanResources].[Employee] Inner Join [Sales].[SalesPerson] on 
HumanResources.Employee.BusinessEntityID=Sales.SalesPerson.BusinessEntityID
Group by JobTitle;



--4
select Name,Color,weight from [Production].[Product] where weight is not Null and color is not null ;

--5
select Description ,isnull(MaxQty,0) from [Sales].[SpecialOffer];


--6
select avg(AverageRate)
from [Sales].[CurrencyRate]
where ToCurrencyCode='GBP' and FromCurrencyCode='USD' and ModifiedDate>='2005-01-01' and ModifiedDate<='2005-12-31';

--7


select row_number() over ( order by firstname ) as [Row Number],FirstName,LastName
from [Person].[Person] 
where firstname like '%ss%';

--8
select 
BusinessEntityID as SalesPersonID, 
CommissionPct,'Commission Band'=
case
when CommissionPct=0 then 'Brand 0'
when CommissionPct>0 and CommissionPct<=0.01 then 'Brand 1'
when CommissionPct>0.01 and CommissionPct<=0.015 then 'Brand 2'
when CommissionPct>0.015  then 'Brand 3'
end from [Sales].[SalesPerson]
order by commissionPct;

--9
SELECT Person.Person.BusinessEntityID, Person.Person.FirstName, Person.Person.MiddleName, 
Person.Person.LastName, HumanResources.EmployeePayHistory.Rate,                      
HumanResources.Employee.OrganizationLevel, HumanResources.Employee.JobTitle 
FROM HumanResources.Employee 
INNER JOIN
HumanResources.EmployeePayHistory ON HumanResources.Employee.BusinessEntityID = HumanResources.EmployeePayHistory.BusinessEntityID 
INNER JOIN
Person.Person ON HumanResources.Employee.BusinessEntityID = Person.Person.BusinessEntityID 
WHERE Person.person.BusinessEntityID<49                      
ORDER BY Person.person.BusinessEntityID ASC;

--10
--select Count(*) from [Production].[Product] group by SafetyStockLevel having SafetyStockLevel=max(SafetyStockLevel) order by SafetyStockLevel;


go
alter function [dbo].[ufnGetStock]()
RETURNS [int] 
AS 
-- Returns the stock level for the product. This function is used internally only
BEGIN
    DECLARE @ret int;
    SELECT @ret = max(Quantity) 
    FROM [Production].[ProductInventory] p 
    IF (@ret IS NULL) 
        SET @ret = 0
    
    RETURN @ret
END;
go
select ProductID,Quantity from [Production].[ProductInventory] where Quantity= [dbo].[ufnGetStock]() ;


