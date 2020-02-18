using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Health health;
    
    public void Start()
    {
        GetComponent<Slider>().value = GetComponent<Slider>().maxValue = health.maxHp;
    }

    public void Update()
    {
        GetComponent<Slider>().value = health.hp;
    }
}
