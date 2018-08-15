using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DogController : MonoBehaviour {
    public float moveSpeed;
    private Rigidbody2D myRidgetbody;

    private bool moving;
    public float timeBetweenMove; //we need one more thing to not count to 0 and recount
    private float timeBetweenMoveCounter;
    public float timeToMove;
    private Vector3 moveDirection;
    private float timeToMoveCounter;


    public float waitToReload;
    private bool reloading;
    private GameObject thePlayer;

	// Use this for initialization
	void Start () {
        myRidgetbody = GetComponent<Rigidbody2D>();
        timeBetweenMoveCounter = timeBetweenMove;
        timeToMoveCounter = timeToMove;

            

		
	}
	
	// Update is called once per frame
	void Update ()
    {
       
        if (moving)
        {

            timeToMoveCounter -= Time.deltaTime;
            myRidgetbody.velocity = moveDirection;

            if(timeToMoveCounter < 0f)
            {
                moving = false;
                timeBetweenMoveCounter = timeBetweenMove;
            }
        }
        else //if not moving
        {
            timeBetweenMoveCounter -= Time.deltaTime;
            myRidgetbody.velocity = Vector2.zero;//it's vecyor with 0 all acess

            if (timeBetweenMoveCounter < 0f)
            {
                moving = true;
                timeToMoveCounter = timeToMove;
                moveDirection = new Vector3(Random.Range(-1f, 1f)*moveSpeed, Random.Range(-1f, 1f)*moveSpeed, 0f);
            }
            
        }

        if (reloading)
        {
            waitToReload -= Time.deltaTime;
            if(waitToReload <0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                thePlayer.SetActive(true);
            }
        }

	}
     void OnCollisionEnter2D(Collision2D other) //create destroy Player
    {
if (other.gameObject.name == "Player")
        {
            // Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            reloading = true;
            thePlayer = other.gameObject;
        }
    }
}
//Make enemy moving randomly