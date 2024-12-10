--31. SELECT: Gib eine Liste der Mitglieder EU und deren Hauptstädte aus. Vergleiche deine Ergebnisse mit der aktuellen Mitgliederliste.
SELECT DISTINCT
    country.name AS Country, 
    city.name AS Capital
FROM 
    ismember 
JOIN 
    country ON ismember.country = country.code 
JOIN 
    city ON country.capital = city.name
WHERE 
    ismember.organization = 'EU'
AND ismember.type = 'member';