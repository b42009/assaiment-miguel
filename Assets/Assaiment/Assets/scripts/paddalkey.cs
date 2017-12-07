using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddalkey : MonoBehaviour {
    float index = 0.00f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("up")){
            if (index < 3.35f)
            {
                index += 0.30f;
            }
        }
        if (Input.GetKey("down"))
        {
            if (index > -3.35f)
            {
                index -= 0.30f;
            }
        }


        Vector3 newpadalposition = new Vector3(gameObject.transform.position.x, index, gameObject.transform.position.z);
        newpadalposition.y = Mathf.Clamp(index, -3.35f, 3.35f);
        gameObject.transform.position = newpadalposition;


    }
}
