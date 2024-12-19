SELECT DISTINCT r.Name AS Name, r.Length AS Length FROM river r
INNER JOIN geo_river gr ON r.Name = gr.River
INNER JOIN province p ON gr.Province = p.Name AND gr.Country = p.Country
INNER JOIN country c ON p.Country = c.Code
WHERE c.Code = 'A'
ORDER BY r.length DESC;