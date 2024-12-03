SELECT distinct
    mountain.name, mountain.Height , geo_mountain.country
  
    
FROM
    mountain,
    geo_mountain
WHERE
    Mountain.name = geo_mountain.mountain
    AND geo_mountain.country Like 'A'
     LIMIT 0, 1;
	