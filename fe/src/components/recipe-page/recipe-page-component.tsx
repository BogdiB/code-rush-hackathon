import { useEffect } from "react";
import { useRecipeStore } from "../../state/recipe_store";
import "./recipe-page.css";
import { fetchRecipe } from "../../services/backend-service";

export function RecipePage() {
	const recipe = useRecipeStore().recipe;
	const isError = useRecipeStore().isError;

	useEffect(() => {
		fetchRecipe();
	}, []);

	return (
		<div className="wrapper">
			{!isError ? (
				recipe ? (
					<p>{recipe.title}</p>
				) : (
					<p>Loading...</p>
				)
			) : (
				<p>Error:((</p>
			)}
		</div>
	);
}
