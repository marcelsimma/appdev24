-- Welche Länder haben genau 3 Städte? Welche Länder sind dies?

SELECT distinct country.Name, country.Code, city.Name
FROM mondial.country
JOIN mondial.province ON country.Code = province.Country
JOIN mondial.city ON province.Country = city.Country

-- noch nicht fertig