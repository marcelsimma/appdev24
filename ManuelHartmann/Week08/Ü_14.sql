SELECT distinct pr.Country, gd.Desert, e.Name, po.Independence
FROM desert d, geo_desert gd, province pr, ethnicgroup e, politics po
WHERE d.Name = gd.Desert
AND gd.Country = pr.Country AND gd.Province = pr.Name
AND pr.Country = e.Country
AND e.Country = po.Country
AND e.Name = 'African'
order by po.Independence asc
;