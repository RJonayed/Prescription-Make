    
select isnull(Max(PresNo)+1,01) As Max from Pres where PresNo= 1001 

Select PName,Gender,PAge,Mobile,PAddress,Email,Remarks from PInfo where PID=1001

Insert Into Pres (PId,PresNo,PDate,PHisty,PProblem,ReAppDate)values('1001','1001',Convert(datetime,'07/09/2020',103),'Accident','Jor',Convert(datetime,'07/09/2020',103))
Insert Into PInfo (PID,PName,Gender,PAge,Mobile,PAddress,Email,Remarks) values('1001','Jonayed','Male','30','01685105029','Noakhali','jonayedrahman26@gmail.com','Na')

Select PId,PDate,PHisty,PProblem,ReAppDate from Pres where PresNo=1001 

Select * from Mdc

Delete from Mdc

Select * from PInfo 

Insert into Mdc(PresNo,SlNo,MName,Qty,MTime,Rmk)values('1001','1001','Napa','10','Rate','Na')

Select MName,Qty,MTime,Rmk from Mdc where SlNo=1001

select isnull(Max(SlNo)+1,01) As Max from Mdc where PresNo= 1001 

Update Mdc Set MName='Histarsin',Qty='20',MTime='Dupore',Rmk='Ace' where SlNo=1001

Select * from  Pres where PresNo=1002

Select * from Test

Insert into Test(PresNo,SlNo,TstName,Rmk)values('1001','1001','Urine','Not Nulls') 
Select TstName,Rmk from Test where SlNo=1001

Update Test set TstName='Blood',Rmk='Nulls' where SlNo=1001

select isnull(Max(SlNo)+1,01) As Max from Test where SlNo= 1001 






