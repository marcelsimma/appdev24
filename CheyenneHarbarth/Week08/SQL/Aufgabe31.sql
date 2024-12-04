SELECT organization.Abbreviation, organization.Name, organization.City, organization.Established, ismember.Country, country.Name, country.Capital
FROM organization
JOIN ismember ON organization.Abbreviation = ismember.Organization
JOIN country ON ismember.Country = country.Code
WHERE organization.Abbreviation = 'EU';