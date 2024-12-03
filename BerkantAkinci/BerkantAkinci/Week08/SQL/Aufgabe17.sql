-- Welche Organisationen haben deren Hauptsitz in Österreich? Wie viele Mitglieder haben diese Organisationen?

SELECT DISTINCT organization.Abbreviation, organization.Name, organization.City, organization.Country, ismember.Type
FROM mondial.organization
JOIN mondial.ismember ON organization.Abbreviation = ismember.Organization
WHERE organization.Country = 'A'