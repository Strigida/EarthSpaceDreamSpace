using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPodDoor : MonoBehaviour {

	public Animator m_doorAnimator;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		m_doorAnimator.SetTrigger ("openPodDoorHal");
		GetComponent<MeshRenderer> ().material.color = new Color32 (255, 248, 175, 255);
	}
}
