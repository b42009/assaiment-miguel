using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class righttriger : MonoBehaviour {
    public Text scoreright;
    public static int sccor = 0;
    public string level;
    public int highscor;
    public string nextlevel;
    public static int reset = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sccor += 1;
        reset = 1;
        //SceneManager.LoadScene(level);
        
            }
    void Start() { }



        // Update is called once per frame
        void Update() {
            scoreright.text = sccor.ToString();
            if (sccor >= highscor)
            {
                SceneManager.LoadScene(nextlevel);
            }


        }
    } 
