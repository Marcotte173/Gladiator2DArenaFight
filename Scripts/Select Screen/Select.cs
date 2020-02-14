using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour
{
    public GameObject Character;
    public bool selected;
    bool mouseOver;
    public GameObject particles;
    GameObject newParticles;

    private void Update()
    {
        if ((Input.GetMouseButtonDown(0) && mouseOver == false) || Input.GetMouseButtonDown(1))
        {
            selected = false;
            Destroy(newParticles);
        }
    }
    void OnMouseDown() 
    { 
        selected = true;
        newParticles = Instantiate(particles, transform.position, transform.rotation);
    }
    void OnMouseEnter() { mouseOver = true; }
    void OnMouseExit() { mouseOver = false; }
}
