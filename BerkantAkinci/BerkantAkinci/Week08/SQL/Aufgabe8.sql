--  Was ist der größte Berg von Österreich? Wie hoch ist er?

SELECT country.Name, mountain.Name, mountain.Height
FROM mondial.geo_mountain 
JOIN mondial.country ON country.Code = geo_mountain.Country
JOIN mondial.mountain ON geo_mountain.mountain = mountain.name
WHERE country.Code = 'A'
ORDER BY mountain.Height DESC
LIMIT 1;