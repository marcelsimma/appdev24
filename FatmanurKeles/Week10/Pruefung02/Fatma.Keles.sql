SELECT DISTINCT r.name AS river, r.length As length
FROM river r
JOIN geo_river ON r.name = geo_river.river
JOIN province ON geo_river.country = province.country
JOIN country ON province.country = country.code
WHERE r.length > 0
ORDER BY r.length DESC;
