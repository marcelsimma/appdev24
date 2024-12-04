USE mondial;

SELECT * FROM country, ismember
WHERE ismember.Country = country.Code AND ismember.Organization = 'EU';