using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityMenu : MonoBehaviour
{
    string ability;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ability = GameManager.instance.agents[0].GetComponent<Stats>().abilityNames[0];
            AbilityList(ability, GameManager.instance.agents[0], GameManager.instance.agents[1] );
        }
    }

    private void AbilityList(string ability, Move agent, Move opponent)
    {
        ///
        if (ability == "Charge")
        {
            if (agent.x == opponent.x)
            {
                if (agent.y > opponent.y + 1)  
                {
                    while (agent.y > opponent.y + 1) { agent.Down(); }
                }
                if (agent.y < opponent.y -1)
                {
                    while (agent.y < opponent.y - 1) { agent.Up(); }
                }
            }
            if (agent.y == opponent.y)
            {
                if (agent.x > opponent.x + 1)
                {
                    while (agent.x > opponent.x + 1) { agent.Left(); }
                }
                if (agent.x < opponent.x - 1)
                {
                    while (agent.x < opponent.x - 1) { agent.Right(); }
                }
            }
        }
        else Debug.Log("Cannot Charge");
        ///


    }
}
