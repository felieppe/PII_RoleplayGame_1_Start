namespace Program;

public class Item {
    private int Damage;
    private int Defense;
    private string Type;
    private int Cost;
    private string Name;
    
    public Item(string name, string type, int cost, int dmg, int dfn) {
        this.Name = name;
        this.Type = type;
        this.Cost = cost;
        this.Damage = dmg;
        this.Defense = dfn;
    }

    public int GetDamage() {
        return this.Damage;
    }
    public int GetDefense() {
        return this.Defense;
    }
    public string GetType() {
        return this.Type;
    }
    public int GetCost() {
        return this.Cost;
    }
    public string GetName() {
        return this.Name;
    }
}