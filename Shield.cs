
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Shield {
    public string Name { get; set; }
    public int ProtectionValue { get; set; }
    public int Durability { get; set; }

    public Shield() {
        Name = "Basic Shield";
        ProtectionValue = 5; // This value might represent how much damage the shield can absorb
        Durability = 50;// Indicates how many hits the shield can take before breaking
    }

    public void BlockAttack()
    {
        // Reduce the durability of the shield when blocking an attack
        if (Durability > 0)
        {
            Durability--;
        }
        else
        {
            // Shield is broken and cannot be used until repaired
        }
    }

    public void Repair()
    {
        // Restore the shield's durability to its maximum value
        Durability = 50; // Assuming 50 is the maximum durability for a basic shield
    }

}