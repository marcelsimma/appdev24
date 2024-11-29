SELECT r.Name, SUM(r.Percentage / 100 * c.Population)
FROM religion r, country c
WHERE r.Country = c.Code
group by r.Name
;