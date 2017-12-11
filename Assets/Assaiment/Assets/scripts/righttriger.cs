using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class righttriger : MonoBehaviour {
    public Text scoreright;
    public static int sccor = 0;
    public int goal;
    public int highscor;
    public string nextlevel;
    public static int reset = 0;
    public static int maxamaunt = 0;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        sccor += goal;
        maxamaunt += goal;
        reset = 1;
        
        
            }
    void Start() { sccor = 0; }



        // Update is called once per frame
        void Update() {
            
        if (sccor >= highscor)
        {
            
            lefttrig.levchan = 1;
        }
        if (lefttrig.levchan == 1)
        {
            
            
            SceneManager.LoadScene(nextlevel);
            

            lefttrig.levchan = 0;



        }

        scoreright.text = sccor.ToString();
    }
    } 
