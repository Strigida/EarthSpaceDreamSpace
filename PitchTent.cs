using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchTent : MonoBehaviour {

    public Animator m_PitchTent;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        m_PitchTent.SetTrigger("OpenCaravanAnimation");
        GetComponent<MeshRenderer>().material.color = new Color32(255, 248, 175, 255);
        Debug.Log("Function OnTriggerEnter Tent working");
    }
}
