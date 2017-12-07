using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       float mousposinunits = (Input.mousePosition.y / Screen.width * 22 )-5;
        Vector3 newpadalposition = new Vector3(gameObject.transform.position.x, mousposinunits, gameObject.transform.position.z);
        newpadalposition.y = Mathf.Clamp(mousposinunits,-3.35f, 3.35f);
        gameObject.transform.position = newpadalposition;
		
	}
}
