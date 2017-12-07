using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class l2scor : MonoBehaviour {

    public Text scoreright;
    public static int sccor = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        sccor += 1;
        SceneManager.LoadScene("level2");

    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scoreright.text = sccor.ToString();

    }
}
