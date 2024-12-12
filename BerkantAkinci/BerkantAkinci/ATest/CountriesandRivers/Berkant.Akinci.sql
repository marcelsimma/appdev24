SELECT DISTINCT geo_river.Country, river.Name, river.Length
FROM geo_river
JOIN river ON geo_river.River = river.Name
WHERE geo_river.Country = @code
ORDER BY river.Length DESC