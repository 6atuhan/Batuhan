use gunluk
go

create proc TUMBILGILERIGETIR

as
begin

SELECT*FROM pazartesi
UNION ALL 
SELECT*FROM sali
UNION ALL 
SELECT*FROM carsamba
UNION ALL 
SELECT*FROM persembe
UNION ALL 
SELECT*FROM cuma
UNION ALL 
SELECT*FROM cumartesi
UNION ALL 
SELECT*FROM pazar

end



