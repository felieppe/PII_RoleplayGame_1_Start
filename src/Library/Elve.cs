using System.Collections;

namespace Program;

public class Elve : ICharacter {
    public string Name {get; set;}
    private CharacterType Type;
    public float Health {get; set;}
    public ArrayList Items {get; set;}

    public Elve() {}

    public string GetName() { return this.Name; }

    public void AddItem(Item item) { Items.Add(item); }
    public void SetName(string name) {
        if (string.IsNullOrEmpty(name)) {
            this.Name = name;
        }
    }
    public void SetType(CharacterType type) {
        if (type != null) {
            this.Type = type;
        }
    }

    public CharacterType GetType() { return this.Type; }

    public float GetTotalDamage() {
        float dmg = 0;
        foreach (Item i in Items) {
            dmg += i.GetDamage();
        }

        return dmg;
    }
    public float GetTotalDefense() {
        float dfn = 0;
        foreach (Item i in Items) {
            dfn += i.GetDefense();
        }

        return dfn;
    }

    public void Heal(float? h) {
        if (h != null) {
            this.Health += (float) h;
        } else { this.Health = 100; }
    }
    public void Damage(float dmg) {
        if (dmg <= this.Health) { this.Health -= dmg; }
        else {
            this.Health = 0;
        }
    }
}