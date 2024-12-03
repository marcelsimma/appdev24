-- Alle Länder, nur die Namen, und wenn sie haben, das Meer dazu

SELECT DISTINCT country.Name, geo_sea.Sea
FROM mondial.country
JOIN mondial.geo_sea ON country.Code = geo_sea.Country
ORDER BY country.Name ASC