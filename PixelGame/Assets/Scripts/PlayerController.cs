using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    //set speed of our character 
    //attach script to Player and put number as speed then write code in Update

    public float moveSpeed;
  
    private Animator anim;

	void Start ()
    {
        anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f) // we can use GetAxis whatever input is press is what we will get. || means "or"

        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f)); //Translate allow us to move character. Time.delta create tiny time.
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f) // Now set movement to Up and Down

        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));//we have value to our X movement
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));//Y movement
    }
}
//After We set movement we need to create 5 animations: Stay, Up, Down, Right and Left then drag art frames to timeline. After that we set connection in Animator for each animation and ass Parameters for movement for X and Y(float)
//then we write code as reference for animation to activate it