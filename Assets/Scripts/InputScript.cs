using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour {

<<<<<<< HEAD
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
=======
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
>>>>>>> 1d148318817073778fb2270feebe1b943a5ec6d9
}
