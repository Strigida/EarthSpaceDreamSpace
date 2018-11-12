using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpBed : MonoBehaviour {

    public Animator m_BedSetup;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        m_BedSetup.SetTrigger("SetUpBedNow");
        GetComponent<MeshRenderer>().material.color = new Color32(255, 248, 175, 255);
        Debug.Log("Function OnTriggerEnter Tent working");
    }
}
