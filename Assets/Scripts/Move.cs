using System;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public bool canMove;
    public int move;
    public int moveLeft;
    public int x;
    public int y;
    void Start()
    {
        move = GetComponent<Stats>().move;
        x = Convert.ToInt32(transform.position.x);
        y = Convert.ToInt32(transform.position.y);        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                bool enemy = false;
                foreach (Move p in GameManager.instance.agents)
                {
                    if (p.x == x + 1 && p.y == y)
                    {
                        GetComponent<BasicAttack>().Go(p);
                        enemy = true;
                        break;
                    }
                }
                if (enemy == false)
                {
                    transform.position = new Vector2(x + 1, y);
                    x++;
                    moveLeft--;
                }
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                bool enemy = false;
                foreach (Move p in GameManager.instance.agents)
                {
                    if (p.x == x - 1 && p.y == y)
                    {
                        GetComponent<BasicAttack>().Go(p);
                        enemy = true;
                        break;
                    }
                }
                if (enemy == false)
                {
                    transform.position = new Vector2(x - 1, y);
                    x--;
                    moveLeft--;
                }                
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                bool enemy = false;
                foreach (Move p in GameManager.instance.agents)
                {
                    if (p.x == x && p.y == y + 1)
                    {
                        GetComponent<BasicAttack>().Go(p);
                        enemy = true;
                        break;
                    }
                }
                if (enemy == false)
                {
                    transform.position = new Vector2(x, y + 1);
                    y++;
                    moveLeft--;
                }                
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                bool enemy = false;
                foreach (Move p in GameManager.instance.agents)
                {
                    if (p.x == x && p.y == y - 1)
                    {
                        GetComponent<BasicAttack>().Go(p);
                        enemy = true;
                        break;
                    }
                }
                if (enemy == false)
                {
                    transform.position = new Vector2(x, y - 1);
                    y--;
                    moveLeft--;
                }                
            }
            if (moveLeft <= 0) canMove = false;
        }        
    }

    void Go()
    {
        canMove = true;
        moveLeft = move;
    }
    private void OnMouseDown()
    {
        Go();
    }
}
