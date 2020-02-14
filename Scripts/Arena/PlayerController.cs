using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{      

    void Go()
    {
        GetComponent<Move>().canMove = true;
        GetComponent<Move>().moveLeft = GetComponent<Move>().move;
    }
    private void OnMouseDown()
    {
        Go();
    }
    void Update()
    {
        if (GetComponent<Move>().canMove)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                bool enemy = false;
                foreach (Move p in AgentInfo.agents)
                {
                    if (p.x == GetComponent<Move>().x + 1 && p.y == GetComponent<Move>().y)
                    {
                        enemy = true;
                        BasicAttack(p);
                        break;
                    }
                }
                if (enemy == false) GetComponent<Move>().Right();
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                bool enemy = false;
                foreach (Move p in AgentInfo.agents)
                {
                    if (p.x == GetComponent<Move>().x - 1 && p.y == GetComponent<Move>().y)
                    {
                        enemy = true;
                        BasicAttack(p);
                        break;
                    }
                }
                if (enemy == false) GetComponent<Move>().Left();
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                bool enemy = false;
                foreach (Move p in AgentInfo.agents)
                {
                    if (p.x == GetComponent<Move>().x && p.y == GetComponent<Move>().y + 1)
                    {
                        enemy = true;
                        BasicAttack(p);
                        break;
                    }
                }
                if (enemy == false) GetComponent<Move>().Up();
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                bool enemy = false;
                foreach (Move p in AgentInfo.agents)
                {

                    if (p.x == GetComponent<Move>().x && p.y == GetComponent<Move>().y - 1)
                    {
                        enemy = true;
                        BasicAttack(p);
                        break;
                    }
                }
                if (enemy == false) GetComponent<Move>().Down();
            }
            if (GetComponent<Move>().moveLeft <= 0) GetComponent<Move>().canMove = false;
        }
    }

    private void BasicAttack(Move p)
    {
        GetComponent<BasicAttack>().Go(p);        
        GetComponent<Move>().moveLeft--;
    }
}