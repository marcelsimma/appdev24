-- SELECT: Gib alle Mitglieder der neuen Organization aus. Sind alle Mitglieder dabei, die du hinzugefügt hast?

SELECT * 
FROM mondial.organization
JOIN mondial.ismember ON organization.Abbreviation = ismember.Organization
WHERE ismember.Organization = 'DCV%';