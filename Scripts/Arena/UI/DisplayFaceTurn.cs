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
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;

    void Update()
    {
        if (changes)
        {
            GetComponent<Image>().sprite = GameManager.instance.agents[0].GetComponent<Stats>().headPic;
            name.text = $"{GameManager.instance.agents[0].GetComponent<Stats>().name}'s turn";
            if (GameManager.instance.agents[0].GetComponent<Move>().moveLeft <= 0) health.text = "Press spacebar to end turn";
            else health.text = $"Moves left: {GameManager.instance.agents[0].GetComponent<Move>().moveLeft}";
        }
        else
        {
            string x = "DEAD";
            if (index == 1)
            {
                GetComponent<Image>().sprite = GameManager.instance.agent1.GetComponent<Stats>().headPic;
                name.text = GameManager.instance.agent1.GetComponent<Stats>().name;
                if (GameManager.instance.agent1.GetComponent<Health>().hp <= 0) health.text = $"<color=red>{x}</color>";
                else health.text = $"HP: {GameManager.instance.agent1.GetComponent<Health>().hp.ToString()}/{GameManager.instance.agent1.GetComponent<Health>().maxHp.ToString()}";
                energy.text = "Energy: " + GameManager.instance.agent1.GetComponent<Stats>().maxEnergy.ToString();
                //Icons for abilities
                if (GameManager.instance.agent1.GetComponent<Stats>().abilities.Count >= 1)
                {
                    image1.SetActive(true);
                    image1.GetComponent<Image>().sprite = GameManager.instance.agent1.GetComponent<Stats>().abilities[0];
                }
                else image1.SetActive(false);
                if (GameManager.instance.agent1.GetComponent<Stats>().abilities.Count >= 2)
                {
                    image2.SetActive(true);
                    image2.GetComponent<Image>().sprite = GameManager.instance.agent1.GetComponent<Stats>().abilities[1];
                }
                else image2.SetActive(false);
                if (GameManager.instance.agent1.GetComponent<Stats>().abilities.Count >= 3)
                {
                    image3.SetActive(true);
                    image3.GetComponent<Image>().sprite = GameManager.instance.agent1.GetComponent<Stats>().abilities[2];
                }
                else image3.SetActive(false);

            }
            else if (index == 2)
            {
                GetComponent<Image>().sprite = GameManager.instance.agent2.GetComponent<Stats>().headPic;
                name.text = GameManager.instance.agent2.GetComponent<Stats>().name;
                if (GameManager.instance.agent2.GetComponent<Health>().hp <= 0) health.text = $"<color=red>{x}</color>";
                else health.text = $"HP:{GameManager.instance.agent2.GetComponent<Health>().hp.ToString()}/{GameManager.instance.agent2.GetComponent<Health>().maxHp.ToString()}";
                energy.text = "Energy: " + GameManager.instance.agent2.GetComponent<Stats>().maxEnergy.ToString();
                //Icons for abilities
                if (GameManager.instance.agent2.GetComponent<Stats>().abilities.Count >= 1)
                {
                    image1.SetActive(true);
                    image1.GetComponent<Image>().sprite = GameManager.instance.agent2.GetComponent<Stats>().abilities[0];
                }
                else image1.SetActive(false);
                if (GameManager.instance.agent2.GetComponent<Stats>().abilities.Count >= 2)
                {
                    image2.SetActive(true);
                    image2.GetComponent<Image>().sprite = GameManager.instance.agent2.GetComponent<Stats>().abilities[1];
                }
                else image2.SetActive(false);
                if (GameManager.instance.agent2.GetComponent<Stats>().abilities.Count >= 3)
                {
                    image3.SetActive(true);
                    image3.GetComponent<Image>().sprite = GameManager.instance.agent2.GetComponent<Stats>().abilities[2];
                }
                else image3.SetActive(false);
            }
            else if (index == 3)
            {
                if (AgentInfo.players < 3) gameObject.SetActive(false);
                else
                {
                    GetComponent<Image>().sprite = GameManager.instance.agent3.GetComponent<Stats>().headPic;
                    name.text = GameManager.instance.agent3.GetComponent<Stats>().name;
                    if (GameManager.instance.agent3.GetComponent<Health>().hp <= 0) health.text = $"<color=red>{x}</color>";
                    else health.text = $"HP:{GameManager.instance.agent3.GetComponent<Health>().hp.ToString()}/{GameManager.instance.agent3.GetComponent<Health>().maxHp.ToString()}";
                    energy.text = "Energy: " + GameManager.instance.agent3.GetComponent<Stats>().maxEnergy.ToString();
                    //Icons for abilities
                    if (GameManager.instance.agent3.GetComponent<Stats>().abilities.Count >= 1)
                    {
                        image1.SetActive(true);
                        image1.GetComponent<Image>().sprite = GameManager.instance.agent3.GetComponent<Stats>().abilities[0];
                    }
                    else image1.SetActive(false);
                    if (GameManager.instance.agent3.GetComponent<Stats>().abilities.Count >= 2)
                    {
                        image2.SetActive(true);
                        image2.GetComponent<Image>().sprite = GameManager.instance.agent3.GetComponent<Stats>().abilities[1];
                    }
                    else image2.SetActive(false);
                    if (GameManager.instance.agent3.GetComponent<Stats>().abilities.Count >= 3)
                    {
                        image3.SetActive(true);
                        image3.GetComponent<Image>().sprite = GameManager.instance.agent3.GetComponent<Stats>().abilities[2];
                    }
                    else image3.SetActive(false);
                }
                
            }
            else if (index == 4)
            {
                if (AgentInfo.players < 4) gameObject.SetActive(false);
                else
                {
                    GetComponent<Image>().sprite = GameManager.instance.agent4.GetComponent<Stats>().headPic;
                    name.text = GameManager.instance.agent4.GetComponent<Stats>().name;
                    if (GameManager.instance.agent4.GetComponent<Health>().hp <= 0) health.text = $"<color=red>{x}</color>";
                    else health.text = $"HP:{GameManager.instance.agent4.GetComponent<Health>().hp.ToString()}/{GameManager.instance.agent4.GetComponent<Health>().maxHp.ToString()}";
                    energy.text = "Energy: " + GameManager.instance.agent4.GetComponent<Stats>().maxEnergy.ToString();
                    //Icons for abilities
                    if (GameManager.instance.agent4.GetComponent<Stats>().abilities.Count >= 1)
                    {
                        image1.SetActive(true);
                        image1.GetComponent<Image>().sprite = GameManager.instance.agent4.GetComponent<Stats>().abilities[0];
                    }
                    else image1.SetActive(false);
                    if (GameManager.instance.agent4.GetComponent<Stats>().abilities.Count >= 2)
                    {
                        image2.SetActive(true);
                        image2.GetComponent<Image>().sprite = GameManager.instance.agent4.GetComponent<Stats>().abilities[1];
                    }
                    else image2.SetActive(false);
                    if (GameManager.instance.agent4.GetComponent<Stats>().abilities.Count >= 3)
                    {
                        image3.SetActive(true);
                        image3.GetComponent<Image>().sprite = GameManager.instance.agent4.GetComponent<Stats>().abilities[2];
                    }
                    else image3.SetActive(false);
                }
                
            }
        }
    }
}