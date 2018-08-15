using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour {
    public int playerMaxHelath;
    public int playerCurrentHealth;

	// Use this for initialization
	void Start ()
    {
        playerCurrentHealth = playerMaxHelath;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	if(playerCurrentHealth <= 0)
        {
            gameObject.SetActive(false);

           
        }
	}

    public void HurtPlayer(int damageToGive)//what amount in ()
    {
        //when hit object player in Enemy script to call this function. So we don't need to destroy player but get him hurt
        //playerCurrentHealth -=  playerCurrentHealth - damageToGive shotrer way:
        playerCurrentHealth -= damageToGive;
            
    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHelath;
    }


}
