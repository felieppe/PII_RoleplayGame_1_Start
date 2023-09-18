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

        /*
            JUSTIFICACIÓN:
            Este test se encarga de realizar una prueba, de modo que no pueden haber 2 o 
            más hechizos con el mismo nombre, ya que si el nombre se repite 2 veces,
            el result2(último hechizo agregado) se considerará falso
        */
        [Test]
        public void TestDuplicatedSpell(){
            SpellBook book = new SpellBook();
            Spell sp = new Spell("Heal");

            bool result = book.AddSpell(sp);
            bool result2 = book.AddSpell(sp);
            Assert.False(result2);
        }

        /*
            JUSTIFICACIÓN:
            Este test verifica que el costo de los items no sea un número negativo,
            si es, devuelve false, de lo contrario se guarda el valor asignado del costo.
        */
        [Test]
        public void TestNegativeCost(){
            Item hacha = new Item("hacha", "Arma", -50, 15, 0);
            Assert.False(hacha.SetCost(-50));
        }
        /*
            JUSTIFICACIÓN:   
            Este test verifica que un mago no tenga mas un libro de hechizos      
        */ 
        [Test]
        public void TestDuplicatedSpellBook(){
            SpellBook sps=new SpellBook();
            Wizard wiz= new Wizard();

            bool result= wiz.SetSpellBook(sps);
            bool result2=wiz.SetSpellBook(sps);
            Assert.False(result2);
        }
    }
}