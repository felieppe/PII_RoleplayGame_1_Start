using System.Collections;

namespace Program;

public class Character {
    private string Name;
    private CharacterType Type;
    private float Health = 100;
    private ArrayList Items;
    public Character(string name, CharacterType type) {
        this.Name = name;
        this.Type = type;
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
    public void SetType(CharacterType type) {
        if (type != null) {
            this.Type = type;
        }
    }

    public CharacterType GetType() {
        return this.Type;
    }
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
        this.Health -= dmg;
    }
}