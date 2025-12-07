import type { RecipeType } from "./recipe_types";

export type AppPages = "main" | "recipe" | "end";

export interface PagesState {
	current_page: AppPages;
	set: (given: AppPages) => void;
	reset: () => void;
}

export interface RecipesState {
	recipe: RecipeType | null;
	isError: boolean;
	set: (recipe: RecipeType) => void;
	setError: () => void;
	reset: () => void;
}
