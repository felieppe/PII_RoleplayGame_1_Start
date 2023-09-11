using System.Collections;

namespace Program;

public class Wizard {
    private string Name;
    private float Health = 100;
    private ArrayList Items;
    public Wizard(string name) {
        this.Name = name;
    }

    public string GetName() {
        return this.Name;
    }

    public void AddItem(Item item) {
        Items.Add(item);
    }

    public void SetName(string name) {
        if (string.IsNullOrEmpty(name)) {
            this.Name = name;
        }
    }

    public void Heal() {
        this.Health = 100;
    }
    public void Damage(int dmg) {
        this.Health -= dmg;
    }
}