using NUnit.Framework;

namespace Program
{
    public class RoleplayGameTests
    {
        /*
            JUSTIFICACIÓN:
            Este caso de prueba lo que revisa es si, al agregar un aspecto tan importante
            como el nombre de un personaje, es vacio o nulo.
            Si el llamado de la función devuelve TRUE, significa que el nombre pasó las validaciones correspondientes.
            Si devuelve FALSE, es sinonimo que el nombre no es valido para el personaje. 
        */
        [Test]
        public void TestBlankWizardName() {
            Wizard wiz = new Wizard();
            string newWizardName = "";

            bool result = wiz.SetName(newWizardName);
            Assert.False(result);
        }
    }
}