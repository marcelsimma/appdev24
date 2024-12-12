USE mondial;

SELECT DISTINCT river.Name AS River, river.Length AS Length
FROM river
JOIN geo_river ON river.Name = geo_river.River
WHERE geo_river.Country = @code
ORDER BY Length;