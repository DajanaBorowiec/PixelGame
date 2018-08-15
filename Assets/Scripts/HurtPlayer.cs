using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {
    public int damageToGive;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other) //create destroy Player
    {
        if (other.gameObject.name == "Player")
         {

            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);//object will get component. we can put number of damage in () but to make script use to diffrent enemy we can make it up in start
          
         }
    }
}
