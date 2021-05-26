Create proc agregar
			@ingreso numeric(12,2),
			@otroingreso numeric(12,2),
			@soat numeric(12,2),
			@tecno numeric(12,2),
			@aceite numeric(12,2),
			@gasolina numeric(12,2),
			@reserva numeric(12,2),
			@ahorro numeric(12,2),
			@incentivo numeric(12,2)
as
insert into FECHA Values(DATEPART(DAY,GETDATE()), DATEPART(MONTH,GETDATE()),DATEPART(YEAR,GETDATE()),GETDATE())

DECLARE @idfecha INT
set @idfecha = @@IDENTITY

insert into INGRESOS values('Quincena',@ingreso,@idfecha)

if (@otroingreso <> 0)
	insert into INGRESOS values('Otros',@ingreso,@idfecha)

insert into GASTOS values('Soat',@soat,@idfecha,'Fijo'),
						('Tecnomecanica',@tecno,@idfecha,'Fijo'),
						('Gasolina',@gasolina,@idfecha,'Variable'),
						('Aceite',@aceite,@idfecha,'Variable')

insert into AHORROS values('Reserva 11% ',@reserva,@idfecha),
						('Colchon (2.000.000)',@ahorro,@idfecha),
						('Incentivo',@incentivo,@idfecha)
