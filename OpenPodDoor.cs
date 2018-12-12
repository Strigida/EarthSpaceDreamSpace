using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(AudioSource))]

public class OpenPodDoor : MonoBehaviour {

    public AudioClip m_doorSound;
    AudioSource audioSource;

	public Animator m_doorAnimator;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {

        if(other.gameObject.tag == "hand")
        {
            m_doorAnimator.SetTrigger("openPodDoorHal");
            GetComponent<MeshRenderer>().material.color = new Color32(255, 248, 175, 255);
            audioSource.PlayOneShot(m_doorSound, 1f);
        }
	}
}
