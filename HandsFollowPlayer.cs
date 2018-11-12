using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsFollowPlayer : MonoBehaviour {

    public GameObject avatar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //raising avatar hands, because they were too low down. Then avatar is paired to the camera, so player can actually move around using controllers.
        Vector3 raisedHands = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1.2f, gameObject.transform.position.z);
        avatar.transform.position = raisedHands;
	}
}
