create table Biotable
(
id int primary key identity(1,1),
Name  varchar(500) not null,
Gender varchar(500) not null,
Location varchar(500) not null
)
insert into Biotable values('Siva','male','address1')
Select * from Biotable

-- insert records into PersonalBio 
create or alter procedure InsertBiotable(@Name nvarchar(100),@Gender nvarchar(100),@Location nvarchar(100))
as
begin

  insert into Biotable (Name,Gender,Location)values (@Name,@Gender,@Location)
end

exec InsertBiotable  'Siva','male','address1'

-------select sp
create or alter procedure SelectBiotable
as
begin

  Select * from Biotable

end

exec SelectBiotable

-------select sp with id
create or alter procedure selectsBiotablewithid(@id int)
as
begin

  Select * from Biotable where id =@id

end

exec selectsBiotablewithid 2

--ubdate

create or alter  procedure UbdateBiotable (@Name nvarchar(100),@Gender nvarchar(100),@Location nvarchar(100),@id int)
as
begin

  update Biotable set Name =@Name,Gender=@Gender, Location=@Location where id=@id

end

exec UbdateBiotable 'hellosiva','ww','my address s',2

--delete
create or alter procedure DeleteBiotable (@id int)
as
begin

  delete from Biotable where id =@id

end

exec DeleteBiotable 1