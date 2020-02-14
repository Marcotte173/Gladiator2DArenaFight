using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public int speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) CenterCamera();
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= Vector3.up * speed * Time.deltaTime;
        }
    }

    void CenterCamera()
    {
        transform.position = new Vector3(transform.position.x, GameManager.instance.agents[0].x,-10);
    }
}
