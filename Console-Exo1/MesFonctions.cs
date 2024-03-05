

using System.Text.Json.Serialization;

namespace Console_Exo1 {

    public class MesFonctions {

        public static string CreerMessage(string nom, int age, int nbCours = -1) {
            var message1 = "";
            if (age == 0) {
                message1 = $"Bonjour {nom.Trim()}, tu es un bébé. ";
            } else if (age == 1) {
                message1 = $"Bonjour {nom.Trim()}, tu as un an.";
            } else {
                message1 = $"Bonjour {nom.Trim()}, tu as {age} ans.";
            }

            if (nbCours>0) {
                message1 = message1 + $" Tu suis {nbCours} cours.";
            }
            return message1 ;
        }

        public static int DemandeInt(string message) {
            int result;
            while (true) {
                string userInput = DemandeString(message);
                if (int.TryParse(userInput, out result) == false) {
                    Console.WriteLine("Idiot, saisie incorrecte");
                } else {
                    break;
                }
            }
            return result;
        }

        public static string DemandeString(string message) {
            string result;
            while (true) {
                Console.WriteLine(message);
                string userInput = Console.ReadLine() ?? string.Empty;
                if (string.IsNullOrEmpty(userInput)) {
                    Console.WriteLine("Idiot, saisie incorrecte");
                } else {
                    result = userInput;
                    break;
                }
            }
            return result;
        }
    }
}
