-- Welche Flüsse fließen durch Europa (nur den Flussnamen)?

SELECT Distinct river 
FROM mondial.encompasses, mondial.geo_river 
WHERE encompasses.country = geo_river.country 
    AND Continent = 'Europe';