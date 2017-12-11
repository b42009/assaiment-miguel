using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball : MonoBehaviour {
    bool gamestart = false;
   

    // Use this for initialization
    void Start () {
        gameObject.transform.position = new Vector3(0, 0, gameObject.transform.position.z);



    }
	
	// Update is called once per frame
	void Update () {
        if(righttriger.reset == 1 || lefttrig.reset ==1)
        {
            gameObject.transform.position = new Vector3(0, 0, gameObject.transform.position.z);
            righttriger.reset = 0;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            righttriger.reset = 0;
            lefttrig.reset = 0;
        }
        
        if (!gamestart)
        {
            gameObject.transform.position = new Vector3(0, 0, gameObject.transform.position.z);
        }
        if (Input.GetMouseButtonDown(0) && righttriger.reset == 0 )
        {
            float Yaxes;
            float Xaxes;
            int i = Random.Range(0, 2);
            if (i == 0)
            {
                Yaxes = Random.Range(1.0f, 3.0f);
            }
            else
            {
                Yaxes = Random.Range(8.0f, 10.0f);
            }

            int b = Random.Range(0, 2);
            if (b == 0)
            {
                 Xaxes = 10;
            }
            else
            {
                Xaxes = -10;
            }
            
            
            gamestart = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(Xaxes, Yaxes);
        }
        
            if (Input.GetMouseButtonDown(0) && lefttrig.reset == 0)
        {
            float Yaxes;
            float Xaxes;
            int i = Random.Range(0, 2);
            if (i == 0)
            {
                Yaxes = Random.Range(1.0f, 3.0f);
            }
            else
            {
                Yaxes = Random.Range(8.0f, 10.0f);
            }

            int b = Random.Range(0, 2);
            if (b == 0)
            {
                Xaxes = 10;
            }
            else
            {
                Xaxes = -10;
            }


            gamestart = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(Xaxes, Yaxes);
            righttriger.reset = 2;
            lefttrig.reset = 2;
        }


    }
}
