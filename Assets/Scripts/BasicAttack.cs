using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttack : MonoBehaviour
{
    public void Go(Move p)
    {
        p.GetComponent<Health>().TakeDamage(2);
    }
}
