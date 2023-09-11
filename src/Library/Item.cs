namespace Program;

public class Item {
    private int DamagePoints;
    private int DefensePoints;
    private string Type;
    private int Cost;
    private string Name;
    public Item(string name, string type, int cost, int dmg, int dfn) {
        this.Name = name;
        this.Type = type;
        this.Cost = cost;
        this.DamagePoints = dmg;
        this.DefensePoints = dfn;
    }
}