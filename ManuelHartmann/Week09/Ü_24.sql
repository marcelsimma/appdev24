-- Update Höhe des Grossglockner.
use mondial;

update mountain
SET mountain.Height = 3798
WHERE mountain.Name =  'Grossglockner'
;

-- Check Höhe von Grossglockner.
use mondial;

SELECT mountain.Name, mountain.Height 
FROM mondial.mountain
WHERE mountain.Name = 'Grossglockner'
;