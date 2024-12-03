SELECT distinct c.Name AS Country, l.Name AS Lake, l.Depth AS 'L-Depth', m.Name AS Mountain, m.Height AS 'M-Height'
FROM mondial.lake l, mondial.geo_lake gl, mondial.mountain m, mondial.geo_mountain gm, mondial.province p, mondial.country c
WHERE m.Name = gm.Mountain AND m.Height >= 1500
AND gm.Country = p.Country AND gm.Province = p.Name
AND p.Country = c.Code
AND l.Name = gl.Lake AND l.Depth >= 100
AND gl.Country = p.Country AND gl.Province = p.Name
AND p.Country = c.Code
ORDER BY c.Name
;