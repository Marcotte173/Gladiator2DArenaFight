using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int strength;
    public int agility;
    public int maxHp;
    new public string name;

    public void Awake()
    {
        if (name == "") name = Names.Return();
    }
}
