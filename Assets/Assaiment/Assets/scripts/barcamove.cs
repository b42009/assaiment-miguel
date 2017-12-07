using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barcamove : MonoBehaviour {
    float index;
    bool simbil;
    // Use this for initialization
    void Start () {

        gameObject.transform.position = new Vector3(transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

    }
	
	// Update is called once per frame
	void Update () {
        if (index >= 3)
        {
            simbil = true;
        }
        if (index <= -3)
        {
            simbil = false;
        }
        if (simbil == false)
        {
            index += 0.05f;
        }
        if (simbil == true)
        {
            index -= 0.05f;
        }




        Vector3 newpadalposition = new Vector3(gameObject.transform.position.x, index, gameObject.transform.position.z);
        newpadalposition.y = Mathf.Clamp(index, -3.35f, 3.35f);
        gameObject.transform.position = newpadalposition;
    }
}
