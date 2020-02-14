using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GetName : MonoBehaviour
{
    public Stats stats;

    private void Start()
    {
        GetComponent<Text>().text = stats.name;
    }
}
