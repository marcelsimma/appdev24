SELECT organization.Abbreviation, organization.Name, COUNT(ismember.Type) AS Members, organization.City, country.Name, country.Code
FROM organization
JOIN country ON organization.Country = country.Code
JOIN ismember ON organization.Abbreviation = ismember.Organization
WHERE country.Name = 'Austria'
GROUP BY organization.Abbreviation;