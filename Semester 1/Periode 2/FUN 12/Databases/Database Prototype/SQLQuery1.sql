﻿SELECT * FROM RECIPES;

SELECT * FROM INGREDIENTS;

SELECT A.Name FROM INGREDIENTS A
INNER JOIN RECIPEINGREDIENT B ON A.Id = B.IngredientId
WHERE B.RecipeId = 1;

UPDATE RECIPES
SET NAME = 'Super Salad'
WHERE Id = 1;

INSERT INTO RECIPES
VALUES('Mega Salad', 40, 'Combine a huge load of stuff');

DELETE FROM RECIPES
WHERE ID = 5;

SELECT a.Name FROM RECIPES a