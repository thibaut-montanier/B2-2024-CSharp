using Console_Exo1.Services;

// récupération des données utilisateurs


while (true) {
    int entreeMenu = InteractionUtilisateurService.DemandeInt(@"Que voulez vous faire ?
1. Créer une personne 
2. Afficher les personnes
3. Creer 10000 personnes
10. Quitter");
    if (entreeMenu == 1) {
        PersonnesService.CreerPersonne();
    } else if (entreeMenu == 2) {
        PersonnesService.AfficherPersonnes();
    } else if (entreeMenu == 3) {
        PersonnesService.CreerNPersonnes(1000);
    } else if (entreeMenu == 10) {
        break;
    } else {
        InteractionUtilisateurService.AfficherMessage("entrée invalide");
    }
}

// pour attendre que l'utilisateur veuille bien quitter
InteractionUtilisateurService.LireSaisieUtilisateur();



