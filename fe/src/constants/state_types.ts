export interface AppState {
	current_page: AppPages;
	set: (given: AppPages) => void;
	reset: () => void;
}

export type AppPages = "main" | "recipe" | "end";
