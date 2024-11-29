SELECT c.Name, p.Name, p.Population
FROM country c, province p
WHERE c.Name LIKE 'A%' AND (c.Code = p.Country)
ORDER BY p.Population DESC
;