/* datenbank zuerst löschen */
DROP DATABASE zoosimulation;

CREATE DATABASE zoosimulation;
USE zoosimulation;

/* alternativ: [IF NOT EXISTS]
CREATE TABLE IF NOT EXISTS `city` (
https://www.mysqltutorial.org/mysql-basics/mysql-create-table/
~in Verbindung mit INSERT Statements auf bestehende Datenbank
*/

CREATE TABLE `city` (
  `Name` varchar(35) NOT NULL,
  `Country` varchar(4) NOT NULL,
  `Province` varchar(35) NOT NULL,
  `Population` int(11) DEFAULT NULL,
  `Longitude` float DEFAULT NULL,
  `Latitude` float DEFAULT NULL,
  PRIMARY KEY (`Name`,`Country`,`Province`),
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `city`
  ADD PRIMARY KEY (`Name`,`Country`,`Province`);


