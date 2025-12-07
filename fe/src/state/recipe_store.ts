import { create } from "zustand";
import type { RecipesState } from "../types/state_types";

export const useRecipeStore = create<RecipesState>((set) => ({
	recipe: null,
	isError: false,
	set: (recipe) => set({ recipe, isError: false }),
	setError: () => set({ recipe: null, isError: true }),
	reset: () => set({ recipe: null, isError: false }),
}));
