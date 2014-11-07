 use finanzkontrollen;


insert into user values (null, 'Ricardo da Silva Alcantara', 'alcantarafox@yahoo.com.br', '123');
insert into account values (null, 'Itau');

insert into operation_type values (1, 'receita');
insert into operation_type values (2, 'despesa');
insert into operation_type values (3, 'card');

insert into operation values (null, 'Receita 1', 'Receita 1 do mês de outubro', '2014-09-30 00:00:00', 1, 1000);
insert into operation values (null, 'Receita 2', 'Receita 2 do mês de outubro', '2014-10-30 00:00:00', 1, 220.98);
insert into operation values (null, 'Receita 3', 'Receita 3 do mês de outubro', '2014-10-5 00:00:00', 1, 320.80);

insert into operation values (null, 'Cartão 1', 'Cartão 1 do mês de outubro', '2014-10-5 00:00:00', 3, 0);

insert into compound_operation values (null, 1, 'Compra online 1', 'Compra online 1 de 1', '2014-10-5 00:00:00', '2014-10-5 00:00:00', 1, 150.00);
insert into compound_operation values (null, 1, 'Compra online 2', 'Compra online 1 de 1', '2014-10-5 00:00:00', '2014-10-5 00:00:00', 1, 50.00);
update operation set Ammount = 200;

insert into operation values (null, 'Pagamento 1', 'Descricao Pagamento 1', '2014-10-28 00:00:00', 2, 500);
insert into operation values (null, 'Pagamento 2', 'Descricao Pagamento 2', '2014-10-8 00:00:00', 2, 135.99);
insert into operation values (null, 'Pagamento 3', 'Descricao Pagamento 3', '2014-10-8 00:00:00', 2, 35.99);

insert into operation values (null, 'Receita 1', 'Receita 1 do mês de novembro',  '2014-10-31 00:00:00', 1, 1000);
insert into operation values (null, 'Receita 4', 'Receita 4 do mês de novembro', '2014-10-5 00:00:00', 1, 500);

insert into operation values (null, 'Pagamento 1', 'Descricao Pagamento 1', '2014-11-28 00:00:00', 2, 500);
insert into operation values (null, 'Pagamento 2', 'Descricao Pagamento 2', '2014-11-8 00:00:00', 2, 105.54);
insert into operation values (null, 'Pagamento 3', 'Descricao Pagamento 3', '2014-11-8 00:00:00', 2, 40);
/*
insert into balance (Date, Ammount, AccountId, UpToDate)
 select 
	'2014-09-30 23:59:59',
	(
		select  
		sum(Ammount)
		from (
			select Ammount from operation where 
			TypeId = 1 
			and operation.PayDate between '2014-09-01 00:00:00' and '2014-09-30 23:59:59' 
			union all
			select (Ammount * -1) from operation where 
			TypeId = 2 
			and operation.PayDate between '2014-09-01 00:00:00' and '2014-09-30 23:59:59' 
			) as operation
	),
	1,
	1;

insert into balance (Date, Ammount, AccountId, UpToDate)
 select 
	'2014-10-5 23:59:59',
	(
		select  
		sum(Ammount)
		from (
			select Ammount from operation where 
			TypeId = 1 
			and operation.PayDate between '2014-10-01 00:00:00' and '2014-10-5 23:59:59' 
			union all
			select (Ammount * -1) from operation where 
			TypeId = 2 
			and operation.PayDate between '2014-10-01 00:00:00' and '2014-10-5 23:59:59' 
			) as operation
	),
	1,
	1;

insert into balance (Date, Ammount, AccountId, UpToDate)
 select 
	'2014-10-31 23:59:59',
	(
		select  
		sum(Ammount)
		from (
			select Ammount from operation where 
			TypeId = 1 
			and operation.PayDate between '2014-10-6 00:00:00' and '2014-10-31 23:59:59' 
			union all
			select (Ammount * -1) from operation where 
			TypeId = 2 
			and operation.PayDate between '2014-10-6 00:00:00' and '2014-10-31 23:59:59' 
			) as operation
	),
	1,
	1;

insert into balance (Date, Ammount, AccountId, UpToDate)
 select 
	'2014-11-28 23:59:59',
	(
		select  
		sum(Ammount)
		from (
			select Ammount from operation where 
			TypeId = 1 
			and operation.PayDate > '2014-11-01 00:00:00' and '2014-11-28 23:59:59' 
			union all
			select (Ammount * -1) from operation where 
			TypeId = 2 
			and operation.PayDate between '2014-11-01 00:00:00' and '2014-11-28 23:59:59' 
			) as operation
	),
	1,
	1;
*/

select  
	sum(Ammount) as Ammount 
from (
	select Ammount from operation where 
	TypeId = 1 
	-- and operation.PayDate between '2014-10-01 00:00:00' and '2014-10-31 00:00:00' 
	union all
	select (Ammount * -1) from operation where 
	TypeId = 2 
	-- and operation.PayDate between '2014-10-01 00:00:00' and '2014-10-31 00:00:00' 
	) as operation;

 



