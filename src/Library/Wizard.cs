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

    public float GetTotalDamage() {
        float dmg = 0;
        foreach (Item i in Items) {
            dmg += i.GetDamage();
        }

        return dmg;
    }

    public void Heal(float? h) {
        if (h != null) {
            this.Health += (float) h;
        } else { this.Health = 100; }
    }
    public void Damage(float dmg) {
        this.Health -= dmg;
    }
}