SELECT country.Name, country.Code, country.Population, religion.Name, religion.Percentage, round((religion.Percentage / 100) * country.Population, 0) AS EinwohnerProReligion
FROM country
JOIN religion ON country.Code = religion.Country;
