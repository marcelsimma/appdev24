USE mondial;

-- in table organization
INSERT INTO organization VALUES ('ADCVG', 'Alumni DCV-Grundkurs', 'Bregenz', 'A', 'Vorarlberg', '2025-01-28');

-- in table ismember
UPDATE ismember SET Organization = 'ADCVG' WHERE Organization = 'DCVG';