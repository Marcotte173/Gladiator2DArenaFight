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
    public Camera cam;

    public void Awake()
    {
        instance = this;
        agent1 = Instantiate(AgentInfo.agents[0].gameObject, new Vector2(0, 0), transform.rotation);
        agents.Add(agent1.GetComponent<Move>());
        agent2 = Instantiate(AgentInfo.agents[1].gameObject, new Vector2(0, 7), transform.rotation);
        agents.Add(agent2.GetComponent<Move>());
        cam.GetComponent<CameraMove>().CameraCenter();
    }

    private void Update()
    {
        agents[0].GetComponent<Move>().turn = true;        
        agents[1].GetComponent<Move>().turn = false ;
        if (Input.GetKeyDown(KeyCode.Space)) NewTurn();
    }

    public void NewTurn()
    {
        Move temp;
        temp = agents[0];
        agents[0] = agents[1];
        agents[1] = temp;
        agents[0].GetComponent<Move>().moveLeft = 3;
        cam.GetComponent<CameraMove>().CenterCamera();
    }
}