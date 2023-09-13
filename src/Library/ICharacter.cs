using System.Collections;

namespace Program;

public interface ICharacter {
    string Name {get; set;}
    float Health {get; set;}
    ArrayList Items {get; set;}

    string GetName();

    void AddItem(Item item);
    void SetName(string name);
    void Heal(float? h);
    void Damage(float dmg);

    float GetTotalDamage();
    float GetTotalDefense();
}