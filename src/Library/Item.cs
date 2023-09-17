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
    public bool SetDamage(int damage){
        if (damage < 0) { return false; }
        else {
            this.Damage = damage;
            return true;
        }
    }
    public int GetDefense() {
        return this.Defense;
    }
    public bool SetDefense(int defense){
        if (defense < 0) { return false; }
        else {
            this.Defense = defense;
            return true;
        }
    }
    public new string GetType() {
        return this.Type;
    }
    public int GetCost() {
        return this.Cost;
    }
    public bool SetCost(int cost){
        if (cost < 0) { return false; }
        else {
            this.Cost = cost;
            return true;
        }
    }
    public string GetName() {
        return this.Name;
    }
}