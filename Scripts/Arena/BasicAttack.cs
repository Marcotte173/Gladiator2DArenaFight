using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttack : MonoBehaviour
{
    public void Go(Move p)
    {
        int attackRoll = Random.Range(1, 101);
        AgentInfo.combatMessage = $"<color=cyan>{GetComponent<Stats>().name}</color> attacks\n\n";
        if (attackRoll  <= GetComponent<CombatStats>().attack - p.GetComponent<CombatStats>().defend)
        {
            p.GetComponent<Health>().TakeDamage(GetComponent<CombatStats>().damage);
            AgentInfo.combatMessage +=  $"<color=cyan>{GetComponent<Stats>().name}</color> hits <color=cyan>{p.GetComponent<Stats>().name}</color> for <color=red>{GetComponent<CombatStats>().damage}</color> damage!";
        }
        else AgentInfo.combatMessage += $"<color=cyan>{GetComponent<Stats>().name}</color> misses <color=cyan>{p.GetComponent<Stats>().name}</color>!";
    }
}
