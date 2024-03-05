using Console_Exo1;
using Console_Exo1.Models;
using System.Runtime.Serialization;
// récupération des données utilisateurs
List<Personne> lesPersonnes = new List<Personne>();

while (true) {
    int entreeMenu = MesFonctions.DemandeInt(@"Que voulez vous faire ?
1. Créer une personne, 
2. Afficher les personnes
3. Creer 10000 personnes");
    if (entreeMenu == 1) {
        Personne p = new Personne();
        p.Nom = MesFonctions.DemandeString("Veuillez indiquer votre nom : ");
        p.Age = MesFonctions.DemandeInt("Age : ");
        p.NbCours = MesFonctions.DemandeInt("Combien de cours : ");
        Personne p2 = p;
        // affichage du résultat

        Console.WriteLine(MesFonctions.CreerMessage(p2.Nom, p2.Age, p2.NbCours));
        lesPersonnes.Add(p);
    } else if (entreeMenu == 2) {
        Console.WriteLine("je sais pas faire");
    } else if (entreeMenu == 3) {
        for(int i = 0; i < 10000; i++) {
            Personne p = new Personne();
            p.Nom = "Polo";
            p.Age = 25;
            lesPersonnes.Add(p) ;
        }
        Console.WriteLine("je sais pas faire");
    } else {
        Console.WriteLine("entrée invalide");  
    }
}
    
// pour attendre que l'utilisateur veuille bien quitter
Console.ReadLine();



