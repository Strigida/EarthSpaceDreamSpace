﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchTent : MonoBehaviour {

    public Animator m_PitchTent;

    public GameObject m_secondPhaseScreen;
    private GameObject m_secondPhaseInstance;
    public Vector3 m_secondScreenSpawnPosition;
    
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "hand")
        {
            m_PitchTent.SetTrigger("OpenCaravanAnimation");
            GetComponent<MeshRenderer>().material.color = new Color32(255, 248, 175, 255);
            m_secondPhaseInstance = Instantiate(m_secondPhaseScreen, m_secondScreenSpawnPosition, Quaternion.Euler(0, 180, 0));
        }
        
    }
}
