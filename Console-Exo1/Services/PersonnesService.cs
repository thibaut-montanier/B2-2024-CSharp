using Console_Exo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Console_Exo1.Services {
    public class PersonnesService {
        public InteractionUtilisateurService InteractUsrService { get; set; } 
            = new InteractionUtilisateurService();
        private  List<Personne> lesPersonnes = new List<Personne>();
        public Personne CreerPersonne() {
            Personne p = new Personne();
            p.Nom = InteractUsrService.DemandeString("Veuillez indiquer votre nom : ");
            p.Age = InteractUsrService.DemandeInt("Age : ");
            p.NbCours = InteractUsrService.DemandeInt("Combien de cours : ");
            lesPersonnes.Add(p);
            return p;
        }
        public string CreerMessage(Personne pers) {
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

        public void AfficherPersonnes() {
            foreach(Personne p in lesPersonnes) {
                InteractUsrService.AfficherMessage($"Nom : {p.Nom}");
                InteractUsrService.AfficherMessage($"Age : {p.Age}");
                InteractUsrService.AfficherMessage($"NbCours : {p.NbCours}");
            }
        }

        public void CreerNPersonnes(int nbPersonnes) {
            for (int i = 0; i < nbPersonnes; i++) {
                Personne p = new Personne();
                p.Nom = "Polo";
                p.Age = 25;
                lesPersonnes.Add(p);
            }
        }
    }
}
