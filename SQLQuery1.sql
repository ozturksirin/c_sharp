Create trigger IdEkle
on TblOgrenci
after Insert
as
Declare @ID smallint
select @ID=ID from inserted
insert into TblNotlar(OGRID)values(@ID)
