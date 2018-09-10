using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovesScript : MonoBehaviour {

    public InputScript callInputScript = new InputScript();
    
	// Update is called once per frame
	void Update () {
		if (callInputScript.controller_px == true)
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }

        if (callInputScript.controller_nx == true)
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }

        if (callInputScript.controller_py == true)
        {
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }

        if (callInputScript.controller_ny == true)
        {
            Vector3 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }
    }
}
