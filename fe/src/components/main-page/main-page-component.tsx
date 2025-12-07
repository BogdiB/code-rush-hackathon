import { usePageStore } from "../../state/pages_store";
import "./main-page.css";

export function MainPage() {
	const goToRecipe = usePageStore((state) => state.set);

	return (
		<div className="wrapper">
			<p>Can you complete the mission?</p>
			<button onClick={() => goToRecipe("recipe")}>Get Mission</button>
		</div>
	);
}
