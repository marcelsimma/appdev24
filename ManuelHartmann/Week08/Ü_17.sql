SELECT organization.Name, count(ismember.Type) AS Members
FROM organization, ismember
WHERE ismember.Organization = organization.Abbreviation AND organization.Country = 'A'
GROUP BY organization.Name
;