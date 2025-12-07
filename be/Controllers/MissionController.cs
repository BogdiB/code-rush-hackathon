// Controllers/MissionController.cs
using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Sets the base route to /api/Mission
    public class MissionController : ControllerBase
    {
        // Static list containing all 5 missions/recipes
        private static readonly List<MissionRecipe> AllMissions = new List<MissionRecipe>
        {
            // Misiunea 1: Pastafall
            new MissionRecipe
            {
                Title = "Pastafall",
                Risks = "Carbohidrați în exces",
                EstimatedTimeMinutes = 20,
                Description = "Agentule, avem informații că Operațiunea Pastafall ar putea preveni un atac iminent... al foamei. Obiectivul tău este să infiltrezi spaghetele pe teritoriul farfuriei și să neutralizezi monotonia culinară.",
                Equipment = new List<string>
                {
                    "200 g spaghete de grad tactic",
                    "2 linguri ulei de măsline extravirgin (calibrat)",
                    "2 căței de usturoi (codificați)",
                    "1 roșie mare sau 6 roșii cherry (folosite ca decor)",
                    "Busuioc proaspăt (camuflaj verde)",
                    "Sare și piper (muniție standard)"
                },
                Instructions = new List<string>
                {
                    "Deschide un punct de extracție (a.k.a. oală cu apă). Activează modul fierbere intensă.",
                    "Introdu spaghetele cu atenție. Nu trebuie să fie detectate.",
                    "Într-o tigaie, încălzește uleiul — este agentul dublu. Adaugă usturoiul și lasă-l să dea informații aromate.",
                    "Interceptează roșiile și prăbușește-le în tigaie.",
                    "Unifică echipele: adaugă spaghetele scurse în tigaie.",
                    "Codifică totul cu sare, piper și busuioc.",
                    "Servește imediat. Misiunea nu suportă întârzieri."
                }
            },
            // Misiunea 2: Operation Chicken Spy
            new MissionRecipe
            {
                Title = "Operation Chicken Spy",
                Risks = "Grăsimi nesănătoase (dacă nu e gătit corespunzător)",
                EstimatedTimeMinutes = 30,
                Description = "Agentul Pui a fost infiltrat sub o acoperire crocantă pentru a dezvălui secretele gustului. Misiunea: deghizare perfectă și livrare la standarde Double-Zero.",
                Equipment = new List<string>
                {
                    "500 g piept de pui (Agent Pui)",
                    "100 g făină (Acoperire de Bază)",
                    "2 ouă bătute (Lianți Secreți)",
                    "100 g pesmet panko sau clasic (Acoperire Crocantă)",
                    "Ulei pentru prăjit sau Air Fryer (Mod de Infiltrare)",
                    "Sare, piper, boia de ardei (Coduri de Arome)"
                },
                Instructions = new List<string>
                {
                    "Pregătește 3 zone de camuflaj: Făina, Ouăle, Pesmetul.",
                    "Taie Agentul Pui în fâșii sau cuburi tactice.",
                    "Rulează Puiul prin fiecare zonă succesiv: Făină, Ouă, Pesmet (asigură acoperire totală!).",
                    "Activează Infiltrarea: Prăjește la temperatură medie până la auriu intens sau gătește în Air Fryer.",
                    "Verifică Starea Internă: Asigură-te că puiul este complet pătruns și crocant la exterior.",
                    "Raportează și Servește. Misiunea este completă când acoperirea este crocantă."
                }
            },
            // Misiunea 3: Steak Royale – shaken, not stirred
            new MissionRecipe
            {
                Title = "Steak Royale – shaken, not stirred",
                Risks = "Temperatura insuficientă (primejdie!)",
                EstimatedTimeMinutes = 20,
                Description = "O misiune medium-rare pentru agenți dublu-zero. Obiectivul tău este să manipulezi un T-bone sau mușchi de vită la perfecțiune, fără a compromite suculența internă.",
                Equipment = new List<string>
                {
                    "1 bucată steak (T-bone, Ribeye, Mușchi de vită)",
                    "Ulei de măsline sau unt clarificat (Combustibil de Fricțiune)",
                    "Rozmarin proaspăt (Amplificator Aromatic)",
                    "Câțiva căței de usturoi zdrobiți (Sursa de Informații)",
                    "Sare de mare grosieră, piper negru proaspăt măcinat (Armamentul Primar)"
                },
                Instructions = new List<string>
                {
                    "Pregătire: Scoate steak-ul de la rece cu 30 de minute înainte (uniformizarea temperaturii).",
                    "Armare: Condimentează steak-ul generos cu sare și piper pe ambele părți.",
                    "Fricțiune: Încinge o tigaie din fontă la temperatură maximă. Adaugă uleiul.",
                    "Infiltrare (Sear): Așază steak-ul. Coace 2-3 minute pe fiecare parte pentru o crustă groasă (Royale).",
                    "Aromatizare (Basting): Redu focul, adaugă untul, usturoiul și rozmarinul. Toarnă untul topit peste steak continuu (basting).",
                    "Verificare (Terminarea Misiunii): Scoate steak-ul când atinge temperatura internă dorită (Medium Rare: 57°C).",
                    "Repaus: Lasă steak-ul să se odihnească 5-10 minute (relaxează fibrele) înainte de a servi. **Niciodată, dar NICIODATĂ, să nu îl tai imediat!**"
                }
            },
            // Misiunea 4: Operațiunea Green Detox
            new MissionRecipe
            {
                Title = "Operațiunea Green Detox",
                Risks = "Plictiseală (pentru agenții carnivori)",
                EstimatedTimeMinutes = 10,
                Description = "Eliminarea amenințării calorice prin infiltrarea legumelor sub acoperire. Obiectiv: o salată capabilă să învingă orice criză energetică.",
                Equipment = new List<string>
                {
                    "1 Avocado copt (agentul verde)",
                    "200g de mix de salată (baza de camuflaj)",
                    "1 castravete tăiat cuburi (unitate de răcire)",
                    "50g semințe de floarea soarelui (muniție crocantă)",
                    "Oțet de mere și ulei de măsline (sos de deghizare)",
                    "Sare, piper și suc de lămâie (activatori de gust)"
                },
                Instructions = new List<string>
                {
                    "Securizează legumele: Spală și taie toate ingredientele.",
                    "Neutralizarea Coptă: Taie Avocado-ul și stropește-l imediat cu suc de lămâie pentru a preveni oxidarea (dezactivarea cromatică).",
                    "Asamblare: Într-un bol mare, amestecă baza de camuflaj cu unitățile de răcire și Agentul Verde.",
                    "Pregătirea Deghizării: Amestecă oțetul, uleiul, sarea și piperul pentru a crea sosul.",
                    "Lansare: Toarnă sosul de deghizare peste salată și amestecă ușor.",
                    "Finalizare: Presară semințele de floarea soarelui (muniția crocantă). Servește în maximum 5 minute de la asamblare."
                }
            },
            // Misiunea 5: Sabotaj Dulce
            new MissionRecipe
            {
                Title = "Sabotaj Dulce: Mousse Express",
                Risks = "Dependență imediată de zahăr",
                EstimatedTimeMinutes = 40,
                Description = "O operațiune de infiltrare rapidă a ciocolatei, care necesită doar 3 ingrediente. Obiectiv: un desert luxos, realizat în condiții de timp critic.",
                Equipment = new List<string>
                {
                    "200g ciocolată neagră (Cod: 70%+ cacao)",
                    "3 ouă proaspete (Emulgatori Secreți)",
                    "1 lingură de zahăr (Amplificator Energetic)",
                    "Un praf de sare (echilibrator de gust)",
                    "Fructe de pădure (decor de acoperire)"
                },
                Instructions = new List<string>
                {
                    "Topirea Țintei: Topește ciocolata la bain-marie sau în microunde. Lasă să se răcească ușor.",
                    "Separarea Echipelor: Separă albușurile de gălbenușuri.",
                    "Gălbenușurile: Bate gălbenușurile cu zahărul până se deschid la culoare și se spumează ușor.",
                    "Integrarea: Adaugă ciocolata topită peste amestecul de gălbenușuri și amestecă rapid.",
                    "Armarea Finală: Bate albușurile cu un praf de sare până devin spumă tare (vârfuri rigide).",
                    "Amestecul Final: Încorporează albușurile în amestecul de ciocolată, folosind mișcări ușoare, de jos în sus, pentru a menține aerul (cod 'Airy').",
                    "Securizare: Pune mousse-ul în recipiente și dă-l la frigider cel puțin 30 de minute (sau la congelator 10 minute pentru situații de urgență).",
                    "Servire: Decorează cu fructe de pădure."
                }
            }
        };

        [HttpGet("random")] // The endpoint the React app will call: /api/Mission/random
        public ActionResult<MissionRecipe> GetRandomMission()
        {
            if (AllMissions == null || AllMissions.Count == 0)
            {
                return NotFound("Nu au fost găsite misiuni.");
            }

            // Logic to select a random mission
            var random = new Random();
            int index = random.Next(AllMissions.Count); 

            var selectedMission = AllMissions[index];
            return Ok(selectedMission);
        }
    }
}