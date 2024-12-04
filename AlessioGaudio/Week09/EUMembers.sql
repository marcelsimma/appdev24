SELECT c.code AS 'Länderkürzel',c.name AS 'Name', c.population AS 'Einwohnerzahl','EU' AS 'Mitgliedschaft', m.type AS 'Mitgliedschaftstyp'
FROM country c
JOIN isMember m ON c.code = m.country
WHERE m.organization = 'EU'
AND m.type = 'Member'
ORDER BY c.population ASC