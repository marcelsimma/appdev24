use mondial;

SELECT DISTINCT geo_river.River, river.Length
FROM mondial.country
JOIN geo_river ON country.Code = geo_river.Country
JOIN river ON geo_river.River = river.Name
WHERE country.Code = @code
ORDER BY river.Length DESC;