-- Land 'Transnistrien' zu Country hinzufuegen.
use mondial;

insert into country
SET Name = 'Transnistrien',
Code = 'TTR',
Capital = 'Transe',
Province = 'Transnist',
Area = 65350349.34,
Population = 832193;

-- Verbindung des Landes zu Europa herstellen, indem ich Transnistrien zu encompasses mit dem Schlüssel 'TTR' hinzufuege.
use mondial;

insert into encompasses
SET encompasses.Country = 'TTR',
encompasses.Continent = 'Europe',
encompasses.Percentage = '80';