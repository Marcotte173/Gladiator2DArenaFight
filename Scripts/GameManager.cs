using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager:MonoBehaviour
{
    public void Start()
    {
        Instantiate(AgentInfo.agents[0].gameObject, new Vector2(0, 0), transform.rotation);
        if (AgentInfo.agents.Count >1) Instantiate(AgentInfo.agents[1].gameObject, new Vector2(7, 0), transform.rotation);
        if (AgentInfo.agents.Count > 2) Instantiate(AgentInfo.agents[2].gameObject, new Vector2(0, 7), transform.rotation);
        if (AgentInfo.agents.Count > 3) Instantiate(AgentInfo.agents[3].gameObject, new Vector2(7, 7), transform.rotation);
    }
}