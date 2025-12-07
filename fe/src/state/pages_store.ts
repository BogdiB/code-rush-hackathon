import { create } from "zustand";
import type { AppPages, PagesState } from "../types/state_types";

export const usePageStore = create<PagesState>((set) => ({
	current_page: "main" as AppPages,
	set: (given) => set({ current_page: given }),
	reset: () => set({ current_page: "main" as AppPages }),
}));
