SELECT DISTINCT country.Code, river.Name, river.Length
FROM country
JOIN geo_river ON country.Code = geo_river.Country
JOIN river ON geo_river.River = river.Name
WHERE country.Code = 'A'
ORDER BY river.Length DESC;