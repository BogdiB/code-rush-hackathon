import { useAppStore } from "../../state/store";
import "./main-page.css";

export function MainPage() {
	const goToRecipe = useAppStore((state) => state.set);

	return (
		<div className="wrapper">
			<p>Can you complete the mission?</p>
			<button onClick={() => goToRecipe("recipe")}>Get Mission</button>
		</div>
	);
}
