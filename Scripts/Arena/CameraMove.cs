using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public int speed;
    public static CameraMove instance;

    private void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= Vector3.up * speed * Time.deltaTime;
        }
    }

    //public void CenterCamera()
    //{
    //    transform.position = new Vector3(-2.55f, GameManager.instance.agents[0].y,-10);
    //}
    //
    //public void CameraCenter()
    //{
    //    transform.position = new Vector3(-2.55f, 3.94f, -10);
    //}
}
