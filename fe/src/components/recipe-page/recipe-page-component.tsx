import { useEffect } from "react";
import { useRecipeStore } from "../../state/recipe_store";
import "./recipe-page.css";
import { fetchRecipe } from "../../services/backend-service";
import { RecipeContent } from "../recipe-content/recipe-content-component";

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
					<RecipeContent recipe={recipe} />
				) : (
					<p>Loading...</p>
				)
			) : (
				<p>Error:((</p>
			)}
		</div>
	);
}
