SELECT m.Name, m.Height, gm.Mountain, gm.Province, p.Country, r.Percentage, r.Name
FROM mountain m, geo_mountain gm, province p, country c, religion r
WHERE m.Height between 2999 AND 4000 
AND m.Name = gm.Mountain 
AND gm.Country = p.Country AND gm.Province = p.Name
AND p.Country = c.Code
AND c.Code = r.Country
AND r.Percentage >= 60 AND r.Name = "Roman Catholic"
;