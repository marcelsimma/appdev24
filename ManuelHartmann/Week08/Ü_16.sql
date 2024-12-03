SELECT e.Continent, MAX(m.Height) AS MaxHeight
FROM mountain m, geo_mountain gm, province p, country c, encompasses e, continent cont
WHERE m.Name = gm.Mountain
AND gm.Country = p.Country AND gm.Province = p.Name
AND p.Country = c.Code
AND c.Code = e.Country
AND e.Continent = cont.Name
GROUP BY e.Continent
;