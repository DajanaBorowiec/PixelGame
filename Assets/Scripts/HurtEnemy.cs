using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour {
    public int damageToGive;
    public GameObject damageBlood;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		

	}


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy") //destroy by wepaon
        {
            // Destroy(other.gameObject);
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
            Instantiate(damageBlood, transform.position, transform.rotation); //creating object in world and rotation
        }
    }
}

