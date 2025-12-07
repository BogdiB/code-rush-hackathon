import type { RecipeType } from "../../types/recipe_types";
import "./recipe-content.css";

interface RecipeTypeProps {
	recipe: RecipeType;
}

export function RecipeContent({ recipe }: RecipeTypeProps) {
	return (
		<div className="wrapper">
			<h2>{recipe.title}</h2>
			<br />

			<h3>Durata estimata: {recipe.estimatedTimeMinutes}</h3>
			<h3>Risc: {recipe.risks}</h3>
			<h3>Status: {recipe.status}</h3>

			<h3 className="subtitle">Descriere</h3>
			<p>{recipe.description}</p>

			<h3 className="subtitle">Echipament</h3>
			<ul>
				{recipe.equipment.map((str) => (
					<li>{str}</li>
				))}
			</ul>

			<h3 className="subtitle">Instructiuni</h3>
			<ol>
				{recipe.instructions.map((str) => (
					<li>{str}</li>
				))}
			</ol>
		</div>
	);
}
