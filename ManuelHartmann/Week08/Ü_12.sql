SELECT cy.Name, cy.Population, e.Continent
FROM country cr, city cy, encompasses e
WHERE cy.Country = cr.Code
AND cr.Code = e.Country
AND e.Continent = "America"
order by cy.Population desc
limit 0, 3
;