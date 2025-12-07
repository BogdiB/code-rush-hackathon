import type { JSX } from "react";
import "./App.css";
import { Header } from "./components/header/header-component";
import { MainPage } from "./components/main-page/main-page-component";
import { useAppStore } from "./state/store";
import { RecipePage } from "./components/recipe-page/recipe-page-component";
import { EndPage } from "./components/end-page/end-page-component";
import type { AppPages } from "./constants/state_types";

export default function App() {
	const current_page = useAppStore((state) => state.current_page);
	const map: Record<AppPages, JSX.Element> = {
		main: <MainPage />,
		recipe: <RecipePage />,
		end: <EndPage />,
	};

	return (
		<>
			<Header />
			{map[current_page] ?? <MainPage />}
		</>
	);
}
