using NUnit.Framework;

namespace Program
{
    public class RoleplayGameTests
    {
        [Test]
        public void TestBlankWizardName() {
            Wizard wiz = new Wizard();
            string newWizardName = "";

            bool result = wiz.SetName(newWizardName);
            Assert.False(result);
        }
    }
}