using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GetName : MonoBehaviour
{
    public Text name;
    public Stats stats;

    private void Start()
    {
        name.text = stats.name;
    }
}
