using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class TreeNoises : MonoBehaviour {

    public AudioClip m_treeImpactSound;

    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "hand")
        {
            audioSource.PlayOneShot(m_treeImpactSound, 1f);
        }
    }
}
