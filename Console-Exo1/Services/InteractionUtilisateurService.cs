using Console_Exo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Exo1.Services {
    public class InteractionUtilisateurService {
        
        public static void AfficherMessage(string message) {
            Console.WriteLine(message);
        }

        public static string LireSaisieUtilisateur() {
            return Console.ReadLine() ?? string.Empty;
        }
        public static int DemandeInt(string message) {
            int result;
            while (true) {
                string userInput = DemandeString(message);
                if (int.TryParse(userInput, out result) == false) {
                    AfficherMessage("Idiot, saisie incorrecte");
                } else {
                    break;
                }
            }
            return result;
        }

        public static string DemandeString(string message) {
            string result;
            while (true) {
                AfficherMessage(message);
                string userInput = LireSaisieUtilisateur();
                if (string.IsNullOrEmpty(userInput)) {
                    AfficherMessage("Idiot, saisie incorrecte");
                } else {
                    result = userInput;
                    break;
                }
            }
            return result;
        }
    }
}
