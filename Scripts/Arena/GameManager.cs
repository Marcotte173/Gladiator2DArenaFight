using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager:MonoBehaviour
{
    public static GameManager instance;
    public List<Move> agents;
    public GameObject agent1;
    public GameObject agent2;
    public GameObject agent3;
    public GameObject agent4;
    public Camera cam;
    public GameObject turnCounter;
    public GameObject StartText;

    public void Awake()
    {
        instance = this;
        agent1 = Instantiate(AgentInfo.agents[0].gameObject, new Vector2(0, 0), transform.rotation);
        agents.Add(agent1.GetComponent<Move>());
        agent2 = Instantiate(AgentInfo.agents[1].gameObject, new Vector2(0, 7), transform.rotation);
        agents.Add(agent2.GetComponent<Move>());
        agent3 = null;
        agent4 = null;
        if (AgentInfo.players >= 3)
        {
            agent3 = Instantiate(AgentInfo.agents[2].gameObject, new Vector2(7, 7), transform.rotation);
            agents.Add(agent3.GetComponent<Move>());
        }
        if (AgentInfo.players >= 4)
        {
            agent4 = Instantiate(AgentInfo.agents[3].gameObject, new Vector2(7, 0), transform.rotation);
            agents.Add(agent4.GetComponent<Move>());
        }
        //cam.GetComponent<CameraMove>().CameraCenter();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Next();
        if (turnCounter.activeSelf == false) if (Input.GetKeyDown(KeyCode.Space)) turnCounter.SetActive(true);
        if (StartText.activeSelf == true) if (Input.GetKeyDown(KeyCode.Space)) StartText.SetActive(false);
    }

    void Next()
    {
        NewTurn();
    }

    public void NewTurn()
    {
        Move temp;
        temp = agents[0];
        agents[0] = agents[1];
        if (AgentInfo.players == 2)
        {
            agents[1] = temp;
        }
        else if (AgentInfo.players == 3)
        {
            agents[1] = agents[2];
            agents[2] = temp;
        }
        else if (AgentInfo.players == 4)
        {
            agents[1] = agents[2];
            agents[2] = agents[3];
            agents[3] = temp;
        }
        for (int i = 1; i < agents.Count; i++)
        {
            agents[i].GetComponent<Move>().moveLeft = 0;
        }
        if (agents[0].GetComponent<Health>().hp > 0) agents[0].GetComponent<Move>().moveLeft = 3;
        else Next();
        //cam.GetComponent<CameraMove>().CenterCamera();
    }
}