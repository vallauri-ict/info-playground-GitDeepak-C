SELECT *
FROM Driver
WHERE full_name like '%to%'

SELECT *
FROM dbo.F1('to')

SELECT dbo.F2('to') as Numero_Piloti