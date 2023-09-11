namespace Program;

public class Spell {
    private string Name;

    public Spell(string name) {
        this.Name = name;
    }

    public string GetName() {
        return this.Name;
    }

    public void SetName(string name) {
        if (string.IsNullOrEmpty(name)) {
            this.Name = name;
        }
    }
}