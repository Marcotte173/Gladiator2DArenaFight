using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{      

    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.D) && GetComponent<Move>().moveLeft > 0)
        {
            bool enemy = false;
            foreach (Move p in GameManager.instance.agents)
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
        if (Input.GetKeyDown(KeyCode.A) && GetComponent<Move>().moveLeft > 0)
        {
            bool enemy = false;
            foreach (Move p in GameManager.instance.agents)
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
        if (Input.GetKeyDown(KeyCode.W) && GetComponent<Move>().moveLeft > 0)
        {
            bool enemy = false;
            foreach (Move p in GameManager.instance.agents)
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
        if (Input.GetKeyDown(KeyCode.S) && GetComponent<Move>().moveLeft > 0)
        {
            bool enemy = false;
            foreach (Move p in GameManager.instance.agents)
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
        if (GetComponent<Move>().moveLeft <= 0) GameManager.instance.NewTurn();     
    }

    private void BasicAttack(Move p)
    {
        GetComponent<BasicAttack>().Go(p);        
        GetComponent<Move>().moveLeft--;
    }
}