create proc mostrarTable
		@tabla varchar(15)
as
if (@tabla='Ingresos')
	Select * from INGRESOS
else if (@tabla='Gastos')
	Select * from GASTOS
else if (@tabla='Ingresos')
	select * from AHORROS where ahorro<>'Incentivo'
else if (@tabla='Libre')
	select * from AHORROS where ahorro = 'Incentivo'
else
	raiserror('El nombre de la tabla que envio no se encuentra',16,1)
	
		
			