USE mondial;

SELECT organization.Name, COUNT(ismember.Organization) AS Members 
FROM organization, ismember
WHERE ismember.Organization = organization.Abbreviation AND organization.Country = 'A'
GROUP BY organization.Name
ORDER BY organization.Name;