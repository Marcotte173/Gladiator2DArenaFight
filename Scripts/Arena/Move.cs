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

    public void Up()
    {
        transform.position = new Vector2(x, y + 1);
        y++;
        moveLeft--;
    }
    public void Down()
    {
        transform.position = new Vector2(x, y - 1);
        y--;
        moveLeft--;
    }
    public void Left()
    {
        transform.position = new Vector2(x - 1, y);
        x--;
        moveLeft--;
    }

    public void Right()
    {
        transform.position = new Vector2(x + 1, y);
        x++;
        moveLeft--;
    }
}
