namespace Console_Exo1.Services {
    public interface IInteractionUtilisateurService {
        void AfficherMessage(string message);
        int DemandeInt(string message);
        string DemandeString(string message);
        string LireSaisieUtilisateur();
    }
}