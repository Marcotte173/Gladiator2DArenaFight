using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatStats : MonoBehaviour
{
    public int attack;
    public int defend;
    public int aim;
    public int damage;
    private void Start()
    {
        UpdateStats();
    }
    public void UpdateStats()
    {
        attack += GetComponent<Stats>().agility / 2;
        defend += GetComponent<Stats>().agility / 2;
        aim += GetComponent<Stats>().agility;
        damage += GetComponent<Stats>().strength / 2;
    }
}
