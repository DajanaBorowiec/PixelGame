using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewArea : MonoBehaviour
{
    public string levelToLoad;
	public bool keyRequired;
    public GameObject guiObject;
	public Transform newPosition;
	GameObject player;

    // Use this for initialization
    void Start ()
    {
        guiObject.SetActive(false);
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

 private void OnTriggerEnter2D(Collider2D other)
  {
     if (other.gameObject.tag == "Player" && !keyRequired)
     {
			player.transform.position = newPosition.position;
             /*guiObject.SetActive(true);
                 if (guiObject.activeInHierarchy == true)
                 {
                    Application.LoadLevel(levelToLoad);
                 }*/
			
     }
   }
    private void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }
}
