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
    public void Start()
    {
        instance = this;
        agent1 = Instantiate(AgentInfo.agents[0].gameObject, new Vector2(0, 0), transform.rotation);
        agents.Add(agent1.GetComponent<Move>());
        agent2 = Instantiate(AgentInfo.agents[1].gameObject, new Vector2(0, 7), transform.rotation);
        agents.Add(agent2.GetComponent<Move>());
        NewTurn();
    }

    public void NewTurn()
    {
        agents.Add(agents[0]);
        agents.RemoveAt(0);
        if (agents[0] == agent1.GetComponent<Move>())
        {
            agent1.GetComponent<Move>().moveLeft = agent1.GetComponent<Move>().move;
            agent2.GetComponent<Move>().moveLeft = 0;
        }
        else
        {
            agent1.GetComponent<Move>().moveLeft = 0;
            agent2.GetComponent<Move>().moveLeft = agent2.GetComponent<Move>().move;
        }
    }
}