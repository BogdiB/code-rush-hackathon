import { API_URL } from "../constants/backend_constants";
import { useRecipeStore } from "../state/recipe_store";
import type { RecipeType } from "../types/recipe_types";

export async function fetchRecipe(): Promise<void> {
	const response = await fetch(API_URL + "/Mission/random");

	if (!response.ok) {
		useRecipeStore.getState().setError();
	}

	const data: RecipeType = await response.json();
	useRecipeStore.getState().set(data);
}
