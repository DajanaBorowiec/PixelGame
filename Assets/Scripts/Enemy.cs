using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public LoadNewArea loadNewArea;


    private Rigidbody2D myRidgetbody;
    public float waitToReload;
    private bool reloading;
    private GameObject thePlayer;
    public GameObject monster;



    // Use this for initialization
    void Start()
    {
        myRidgetbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (monster.gameObject.SetActive(false))
            loadNewArea.keyRequired = false;
        if (Input.GetKeyDown(KeyCode.Y))
            loadNewArea.keyRequired = true;
    }
}

        /* if (other.gameovject.SetAcrive(false)) ;
        reloading
        
        if (reloading)
        {
            waitToReload -= Time.deltaTime;
            if (waitToReload < 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                thePlayer.SetActive(true);
            }

        }

        
    }


    
       
    

    
  /*  void OnCollisionEnter2D(Collision2D other) //create destroy Player
    {
        if (other.gameObject.name == "Player")
        {
             Destroy(other.gameObject);
            //other.gameObject.SetActive(false);
            reloading = true;
            thePlayer = other.gameObject;
        }
    }
    */
 