USE mondial;

WITH city AS
(
  SELECT COUNT(city.Name) AS count, city.Country FROM city GROUP BY city.Country
)
SELECT city.Country, count FROM city WHERE count = 3;