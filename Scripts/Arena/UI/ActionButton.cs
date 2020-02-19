using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionButton : MonoBehaviour
{
    public Button action1;
    public Button action2;
    public Button action3;

    private void Awake()
    {
        action1.gameObject.SetActive(false);
        action2.gameObject.SetActive(false);
        action3.gameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GameManager.instance.agents[0].GetComponent<AbilityInterface>().abilities >= 1) action1.gameObject.SetActive(true);
            else action1.gameObject.SetActive(false);
            if (GameManager.instance.agents[0].GetComponent<AbilityInterface>().abilities >= 2) action2.gameObject.SetActive(true);
            else action2.gameObject.SetActive(false);
            if (GameManager.instance.agents[0].GetComponent<AbilityInterface>().abilities >= 3) action3.gameObject.SetActive(true);
            else action3.gameObject.SetActive(false);
        }        
    }
}
