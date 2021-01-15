create view YAZILARIGOSTER
AS
SELECT yazi 
FROM pazartesi
UNION ALL 
SELECT yazi 
FROM sali
UNION ALL 
SELECT yazi 
FROM carsamba
UNION ALL 
SELECT yazi 
FROM persembe
UNION ALL 
SELECT yazi 
FROM cuma
UNION ALL 
SELECT yazi 
FROM cumartesi
UNION ALL 
SELECT yazi 
FROM pazar

