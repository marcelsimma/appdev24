SELECT DISTINCT river.name AS river, river.length As length
FROM river
JOIN geo_river ON river.name = geo_river.river
JOIN province ON geo_river.country = province.country
JOIN country ON province.country = country.code
WHERE river.length IS NOT NULL and country.code = 'A'
ORDER BY river.length DESC;