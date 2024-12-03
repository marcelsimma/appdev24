-- Aufgabe 01
-- Wie viele Einwohner hat Österreich?

SELECT * FROM country WHERE name like "Austria";


-- Aufgabe 02
-- Welche Flüsse fließen durch Österreich?

SELECT * FROM geo_river WHERE country = "A";


-- Aufgabe 03
-- Alle Länder die mit einem A anfangen

SELECT * FROM country WHERE name like "A%";


-- Aufgabe 04
-- Wie viele Einwohner hat der Kontinent Europa?

SELECT * FROM population WHERE country like "A%";


-- Aufgabe 05
-- 5. Welche Flüsse fließen durch Europa (nur den Flussnamen)?

SELECT cn.name, r.name
FROM encompasses ec, country c, province p, geo_river gr, river r, continent cn
WHERE ec.country = c.code
AND c.code = p.country
AND p.country = gr.country
AND p.name = gr.province
AND gr.river = r.name
AND cn.name like "Europe%";


-- Aufgabe 06
-- 6. Alle Flüsse die durch Europa fließen (nur Flüsse und deren Länge), sortiert nach Länge

SELECT cn.name, r.name, r.length
FROM encompasses ec, country c, province p, geo_river gr, river r, continent cn
WHERE ec.country = c.code
AND c.code = p.country
AND p.country = gr.country
AND p.name = gr.province
AND gr.river = r.name
AND cn.name LIKE "Europe"
ORDER BY r.length DESC;


-- Aufgabe 07 WHERE
-- Alle Länder die mit einem A anfangen & deren Bundesländer mit Einwohnerzahl, sortiert nach Einwohnerzahl

SELECT c.name, p.name, p.population
FROM province p, country c
WHERE p.country = c.code
AND c.name LIKE "A%"
ORDER BY c.name, p.population ASC;


-- Aufgabe 07 JOIN

SELECT c.name, p.name, p.population FROM province, country
INNER JOIN country ON p.country = c.code
WHERE c.name LIKE "A%"
ORDER BY c.name, p.population ASC;


-- Aufgabe 08
-- Was ist der größte Berg von Österreich? Wie hoch ist er?

SELECT m.name, m.height
FROM country cy, province p, geo_mountain gm, mountain m
-- Beziehung Country - Provincve
WHERE cy.code = p.country
-- Beziehung Province - geo_mountain
AND p.country = gm.country
AND p.name = gm.province
-- Beziehung geo_mountain - mountain
AND gm.mountain = m.name
-- Höchster Berg von Österreich
AND cy.name like 'Austria'
order by m.height DESC
LIMIT 1;


-- Aufgabe 09
-- Alle Inseln im Pazifik mit >50% islamischem Bekenntnis

SELECT i.name, r.name, r.percentage
FROM religion r, country cy, province p, geo_island gi, island i 
WHERE r.country = cy.code
AND cy.code = p.country
AND p.country = gi.country
AND p.name = gi.province
AND gi.island = i.name
AND r.name = 'Muslim'
order by percentage DESC
LIMIT percentage 50%;
--noch nicht vollständig

SELECT i.name, r.name, r.percentage
FROM religion r, country cy, city c, geo_sea gs, sea s, islandIn ii, island i 
WHERE r.country = cy.code
AND cy.code = c.country
AND c.country = gs.country
AND c.name = gs.city
AND gs.sea = s.name
AND s.name = ii.sea
AND ii.island = i.name
AND r.name = 'Muslim'
order by r.percentage DESC
--unvollständig / enthält Fehler


-- Aufgabe 10
-- Alle 3000er, welche in einem Land sind, welches zu mindestens 60% römisch Katholisch ist

SELECT m.name, c.name, r.name, r.percentage, m.height
FROM religion r, country c, province p, geo_mountain gm, mountain m
WHERE r.country = c.code 
AND c.code = p.country 
AND p.country = gm.country
AND p.name = gm.province
AND gm.mountain = m.name
AND r.name Like '%Catholic'
AND m.height > 3000
AND r.percentage > 60
order by r.percentage DESC


-- Aufgabe 11
-- Einwohnerzahl pro Religion

SELECT r.name, SUM(c.population  * r.Percentage / 100) as anzahl
FROM religion r, country c
WHERE r.country = c.code
GROUP BY r.name
Order by anzahl desc;


-- Aufgabe 12
-- Welches sind die 3 größten Städte von Amerika (Kontinent)?
