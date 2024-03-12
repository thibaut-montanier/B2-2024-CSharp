using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Exo1.Models {
    public class Personne {
        public string Nom { get; set; }
        public int Age { get; set; }
        public int NbCours { get; set; }

    }
}
// Travail à faire
// 1. Changer la signature de MesFonctions.CreerMessage pour qu'elle prenne
//      un parametre de type Personne
// 2. Creer une fonction AffiherLesPersonnes (et demerdez vous avec les
//       paramètres
// 3. Creer une fonction "CreerPersonne" qui s'occupe de demander le nom, 
//       l'age et le nom de cours
// 4. Regrouper les fonctions de gestion des personnes (CreerMessage, 
//       AfficherLesPersonnes, CreerPersonne) dans une classe
//       "PersonnesService"
// 5. Les fonctions "DemanderInt" et DemanderString" doivent être dans une classe
//        "SaisiesUtilisateurService"

// pour récupérer mon code : git clone
// https://github.com/thibaut-montanier/B2-2024-CSharp
