using System.Collections;

namespace Program;

public class Wizard {
    private float Health = 100;
    private ArrayList Items;
    public Wizard() {}

    public void AddItem(Item item) {
        Items.Add(item);
    }
}