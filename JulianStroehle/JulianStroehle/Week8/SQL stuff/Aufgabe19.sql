USE mondial;

SELECT DISTINCT country.Name, geo_sea.Sea
FROM country
LEFT JOIN geo_sea ON country.Code = geo_Sea.Country;