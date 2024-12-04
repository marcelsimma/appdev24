--Für jeden Staat sollen der Name, die Hauptstadt und der Kontinent gespeichert werden.
SELECT 
    Name, 
    Continent, 
    Capital 
FROM 
    mondial.country 
JOIN 
    encompasses 
ON 
    country.code = encompasses.country 
WHERE 
code = 'A';

--Für jeden Staat sollen alle Provinzen mit Name, Hauptstadt und Einwohnerzahl gespeichert werden. 
SELECT 
    province.name, 
    province.capital, 
    Population
FROM 
    mondial.province 
WHERE 
    province.country = 'A';