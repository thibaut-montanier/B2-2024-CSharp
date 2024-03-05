using Console_Exo1;


namespace Console_Exo1Tests {
    public class MesFonctionsTest {

        [Test]
        public void CreerMessageTest() {
            // prepare 
            // execute
            var result = MesFonctions.CreerMessage("    Thibaut   ", 42);

            // verify
            Assert.AreEqual("Bonjour Thibaut, tu as 42 ans.", result);
        }

        [TestCase("Bonjour Thibaut, tu as 42 ans. Tu suis 2 cours.", 2)]
        [TestCase("Bonjour Thibaut, tu as 42 ans. Tu suis 3 cours.", 3)]
        public void CreerMessageAvecCoursTest(string expectedResult, int nbCours) {
            // prepare 
            // execute
            var result = MesFonctions.CreerMessage("    Thibaut   ", 42, nbCours);

            // verify
            Assert.AreEqual(expectedResult, result);
        }
    }
}
