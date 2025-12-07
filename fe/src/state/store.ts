import { create } from "zustand";
import type { AppPages, AppState } from "../constants/state_types";

export const useAppStore = create<AppState>((set) => ({
	current_page: "main" as AppPages,
	set: (given) => set({ current_page: given }),
	reset: () => set({ current_page: "main" as AppPages }),
}));
