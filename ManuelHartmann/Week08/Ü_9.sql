SELECT il.Sea, i.Name, gi.Country, gi.Island, gi.Province, p.Name, p.Country, c.Code, r.Country, r.Name, r.Percentage
FROM islandin il, island i, geo_island gi, province p, country c,  religion r 
WHERE il.Sea = 'Pacific Ocean' AND il.Island = i.Name 
AND i.Name = gi.Island AND gi.Country = p.Country AND gi.Province = p.Name
AND p.Country = c.Code
AND c.Code = r.Country
AND r.Name like 'Muslim' AND r.Percentage > 50
ORDER BY r.Percentage desc
;