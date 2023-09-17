using System.Collections;
using System.Collections.Generic;

namespace Program;

public class SpellBook{
    private ArrayList Spells = new ArrayList();

    public ArrayList GetSpells(){
        return this.Spells;
    }

    public bool AddSpell(Spell sp) {
        if (!(Spells.Contains(sp))) {
            Spells.Add(sp);
            return true;
        } else { return false; }
    }
}


