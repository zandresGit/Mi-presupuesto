
create proc totalahorros
as
Select ahorro,sum(valor) as total from AHORROS group by ahorro