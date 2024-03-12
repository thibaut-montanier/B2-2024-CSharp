using Console_Exo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Exo1.Services {
    internal class PersonnesService {

        private static List<Personne> lesPersonnes = new List<Personne>();
        public static Personne CreerPersonne() {
            Personne p = new Personne();
            p.Nom = InteractionUtilisateurService.DemandeString("Veuillez indiquer votre nom : ");
            p.Age = InteractionUtilisateurService.DemandeInt("Age : ");
            p.NbCours = InteractionUtilisateurService.DemandeInt("Combien de cours : ");
            lesPersonnes.Add(p);
            return p;
        }
        public static string CreerMessage(Personne pers) {
            var message1 = "";
            if (pers.Age == 0) {
                message1 = $"Bonjour {pers.Nom.Trim()}, tu es un bébé. ";
            } else if (pers.Age == 1) {
                message1 = $"Bonjour {pers.Nom.Trim()}, tu as un an.";
            } else {
                message1 = $"Bonjour {pers.Nom.Trim()}, tu as {pers.Age} ans.";
            }

            if (pers.NbCours > 0) {
                message1 = message1 + $" Tu suis {pers.NbCours} cours.";
            }
            return message1;
        }

        internal static void AfficherPersonnes() {
            foreach(Personne p in lesPersonnes) {
                InteractionUtilisateurService.AfficherMessage($"Nom : {p.Nom}");
                InteractionUtilisateurService.AfficherMessage($"Age : {p.Age}");
                InteractionUtilisateurService.AfficherMessage($"NbCours : {p.NbCours}");
            }
        }

        internal static void CreerNPersonnes(int nbPersonnes) {
            for (int i = 0; i < nbPersonnes; i++) {
                Personne p = new Personne();
                p.Nom = "Polo";
                p.Age = 25;
                lesPersonnes.Add(p);
            }
        }
    }
}
