using System.Collections;

namespace Program;

public class Wizard {
    private string Name;
    private float Health = 100;
    private ArrayList Items;
    public Wizard(string name) {
        this.Name = name;
    }

    public void AddItem(Item item) {
        Items.Add(item);
    }
}