using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour {

    public bool controller_px = false;
    public bool controller_nx = false;
    public bool controller_py = false;
    public bool controller_ny = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            controller_px = true;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            controller_nx = true;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            controller_py = true;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            controller_ny = true;
        }

        // checks if both positive and negative directions are pressed and makes them reset to idle if they are the same
        if (controller_px == controller_nx)// for x directions
        {
            controller_px = false;
            controller_nx = false;
        }

        if (controller_py == controller_ny)//for y directions
        {
            controller_py = false;
            controller_ny = false;
        }
    }
}
