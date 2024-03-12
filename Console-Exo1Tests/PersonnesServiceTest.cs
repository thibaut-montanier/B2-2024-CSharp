using Console_Exo1.Models;
using Console_Exo1.Services;
using Moq;


namespace Console_Exo1Tests {
    public class PersonnesServiceTest {

        PersonnesService persService = new PersonnesService();
        [Test]
        public void CreerMessageTest() {
            // prepare 
            Personne p = new Personne();
            p.Nom = "   Thibaut ";
            p.Age = 42;
            PersonnesService persService = new PersonnesService();
            // execute
            var result = persService.CreerMessage(p);

            // verify
            Assert.AreEqual("Bonjour Thibaut, tu as 42 ans.", result);
        }

        [TestCase("Bonjour Thibaut, tu as 42 ans. Tu suis 2 cours.", 2)]
        [TestCase("Bonjour Thibaut, tu as 42 ans. Tu suis 3 cours.", 3)]
        public void CreerMessageAvecCoursTest(string expectedResult, int nbCours) {
            // prepare 
            Personne p = new Personne() {
                Nom = "    Thibaut   ",
                Age = 42,
                NbCours = nbCours
            };
            
            // execute
            var result = persService.CreerMessage(p);

            // verify
            Assert.AreEqual(expectedResult, result);
        }

        [Test()]
        public void CreerPersonneTest() {

            // prepare

            persService.InteractUsrService = new InteractionUtilisateurServiceMock();


            // do
            Personne p = persService.CreerPersonne();

            // verify
            Assert.NotNull(p);
            Assert.AreEqual("Pierre", p.Nom);
            Assert.AreEqual(42, p.Age);
            Assert.AreEqual(42, p.NbCours);
        }

        public class InteractionUtilisateurServiceMock : InteractionUtilisateurService {


            public override int DemandeInt(string message) {
                return 42;
            }



            public override string DemandeString(string message) {
                return "Pierre";
            }

          

        }
    }
}
