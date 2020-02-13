using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int strength;
    public int agility;
    public int maxHp;
    public int move;
    new public string name;

    public void Awake()
    {
        name = Names.Return();
    }
    private void Start()
    {
        GameManager.instance.agents.Add(this.GetComponent<Move>());        
    }
}
