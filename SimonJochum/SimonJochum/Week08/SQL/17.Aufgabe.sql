-- 17) Welche Organisationen haben deren Hauptsitz in Österreich? Wie viele Mitglieder haben diese Organisationen?
USE Mondial;
SELECT organization.name,
       Count(ismember.organization) AS Members
FROM   organization,
       ismember
WHERE  ismember.organization = organization.abbreviation
       AND organization.country = 'A'
GROUP  BY organization.name
ORDER  BY organization.name;  