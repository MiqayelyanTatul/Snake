using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _speed = 2f;

    private void Update()
    {
        transform.Translate(Vector3.up * (_speed * Time.deltaTime));
        
        if (Input.GetKeyDown(KeyCode.RightArrow) & transform.eulerAngles.z != 90)
        {
            transform.eulerAngles = new Vector3(0, 0, 270);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) & transform.eulerAngles.z != 270)
        {
            transform.eulerAngles = new Vector3(0, 0, 90);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) & transform.eulerAngles.z != 180)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) & transform.eulerAngles.z != 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 180);
        }
    }
}
