Create Proc cargarUltIngreso
as
if ((Select COUNT(valor) from INGRESOS where ingreso <> 'Quincena') = 0)
	Select TOP(1) valor, 0 AS otros  from INGRESOS ORDER BY id DESC
else 
	Select TOP(1) valor, (Select TOP(1) valor from INGRESOS where ingreso <> 'Quincena' ORDER BY id DESC) AS otros  from INGRESOS ORDER BY id DESC


Create Proc cargarUltGasto
as
Select TOP(4) gasto, valor  from GASTOS ORDER BY id DESC



Create Proc cargarUltReserva
as
Select TOP(3) *  from AHORROS ORDER BY id DESC