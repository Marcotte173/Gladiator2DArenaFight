using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayFaceTurn : MonoBehaviour
{
    public int index;
    public Text name;
    public Text health;
    public Text energy;
    public bool changes;
    void Update()
    {
        if (changes)
        {
            GetComponent<Image>().sprite = GameManager.instance.agents[0].GetComponent<Stats>().headPic;
            name.text = $"{GameManager.instance.agents[0].GetComponent<Stats>().name}'s turn";
        }
        else
        {
            if (index == 1)
            {
                GetComponent<Image>().sprite = GameManager.instance.agent1.GetComponent<Stats>().headPic;
                name.text = GameManager.instance.agent1.GetComponent<Stats>().name;
                health.text = $"HP: {GameManager.instance.agent1.GetComponent<Health>().hp.ToString()}/{GameManager.instance.agent1.GetComponent<Health>().maxHp.ToString()}";
                energy.text = "Energy: " + GameManager.instance.agent1.GetComponent<Stats>().maxEnergy.ToString();
            }
            else
            {
                GetComponent<Image>().sprite = GameManager.instance.agent2.GetComponent<Stats>().headPic;
                name.text = GameManager.instance.agent2.GetComponent<Stats>().name;
                health.text = $"HP:{GameManager.instance.agent2.GetComponent<Health>().hp.ToString()}/{GameManager.instance.agent2.GetComponent<Health>().maxHp.ToString()}";
                energy.text = "Energy: " + GameManager.instance.agent2.GetComponent<Stats>().maxEnergy.ToString();
            }
        }
    }
}
