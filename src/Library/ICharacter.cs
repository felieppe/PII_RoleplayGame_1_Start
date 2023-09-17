using System.Collections;

namespace Program;

public interface ICharacter {
    string Name {get; set;}
    float Health {get; set;}
    ArrayList Items {get; set;}

    string GetName();

    void AddItem(Item item);
    void RemoveItem(Item item);
    void Heal(float? h);
    void Damage(float dmg);

    bool SetName(string name);

    float GetTotalDamage();
    float GetTotalDefense();
}
/* por el principio expert cada personaje está a cargo de saber sus valores de daño, defensa, etc,
también de tener la lista de sus objetos y la capacidad de obtener nuevos y deshacerse de otros */