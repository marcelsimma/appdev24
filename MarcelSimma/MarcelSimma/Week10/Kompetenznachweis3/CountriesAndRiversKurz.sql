SELECT DISTINCT r.Name AS Name, r.Length AS Length FROM river r
INNER JOIN geo_river gr ON r.name = gr.river
WHERE gr.Country = 'A'
ORDER BY r.Length DESC;