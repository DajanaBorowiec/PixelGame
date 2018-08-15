using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour {
    public GameObject followTarget; //set script to camera and add Player as follow target
    private Vector3 targetPos;
    public float moveSpeed; //how fast camera follow our player
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);//we dont use z osition in 2d so we should use just transform
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);//a=where we are b=where we want to be t=movement
    }//we need now change speed of camera in Unity
}
