using Console_Exo1.Services;

// récupération des données utilisateurs
InteractionUtilisateurService interUser = new InteractionUtilisateurService();
PersonnesService persService = new PersonnesService();
persService.InteractUsrService = interUser;
while (true) {
    int entreeMenu = interUser.DemandeInt(@"Que voulez vous faire ?
1. Créer une personne 
2. Afficher les personnes
3. Creer 10000 personnes
10. Quitter");
    if (entreeMenu == 1) {
        persService.CreerPersonne();
    } else if (entreeMenu == 2) {
        persService.AfficherPersonnes();
    } else if (entreeMenu == 3) {
        persService.CreerNPersonnes(1000);
    } else if (entreeMenu == 10) {
        break;
    } else {
        interUser.AfficherMessage("entrée invalide");
    }
}

// pour attendre que l'utilisateur veuille bien quitter
interUser.LireSaisieUtilisateur();

// exercice : 
// 1. Nous allons avoir 2 types de personnes
//    1. Des étudiants : ils ont un montant à payer (une propriété MontantAPayer)
//    2. Des enseignants : ils touchent un salaire (propriété Salaire)
//    Modifier le programme pour permettre la création d'enseignants ou d'étudiants (à stocker dans la même liste)
//    Pour l'affichage, il serait cool d'afficher le salaire si il s'agit d'un prof ou le montant à payer si il s'agit d'un étudiant
//         if (monA is A1) {
//             ((A1)monA).PropA1 = "tutu";
//         }
// 2. Tests unitaires à réaliser
// 3. Ajouter une fonction "Modifier personne"
//     La fonction commence par demander le nom de la personne
//     Si une ou plusieurs personnes sont trouvées => Reposer les questions pour modifier les propriétés de la personne
//     

//public class A {
//    public string Nom { get; set; }
//}
//public class A1 : A {
//    public string PropA1 { get; set; }
//}
//public class A2 : A { }


//A monA = new A1();
//A2 monA2 = new A();

//A1 monA1 = new A1();
//monA1.Nom = "tutu";
//monA1.PropA1 = "titi";


//monA = monA1;
//monA.Nom = "tutu";
//monA.PropA1 = "titi";

//monA2 = monA1;

//monA = new A2();

//monA2 = monA;

//List<A> mesA = new List<A>();
//mesA.Add(monA1);
//mesA.Add(monA2);

//foreach (A a in mesA) {
//    Console.WriteLine(a.Nom);
//    Console.WriteLine(a.PropA1);
//}