SELECT m.Name, m.Height
FROM mountain m, geo_mountain g
# Hier suche ich einmal den hoechsten Berg Oesterreichs ueber g.Country = "A" und einmal nach den Laengen- und Breitengraden!
where (g.Mountain = m.Name) AND (g.Country = "A") or m.Longitude between 9.6 AND 17.945 AND m.Latitude between 47.0 AND 49.3
order by m.Height DESC
limit 0, 1
;