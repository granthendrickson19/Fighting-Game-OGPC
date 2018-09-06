using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour {

    public int controller_x = 0;
    public int controller_y = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            controller_x = 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            controller_x = -1;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            controller_y = 1;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            controller_y = -1;
        }
    }
}
