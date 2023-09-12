using System.Collections;
using System.Collections.Generic;

namespace Program;

public class CharacterType {
    private List<string> AvailableTypes = new List<string>() {"Wizard", "Elve", "Dwarve"};
    private string ActualType;

    public CharacterType() {}

    public bool SetType(string ty) {
        if (AvailableTypes.Contains(ty)) {
            this.ActualType = ty;
            return true;
        } else { return false; }
    }
}