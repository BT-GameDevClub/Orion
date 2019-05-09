using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Attacker Stats", menuName = "Stats/Attacker", order = 1)]
public class AttackerStats : ScriptableObject
{
    public float maxHealth;
    public float currentHealth;

    // Also store inventory, abilities, etc. here
}
