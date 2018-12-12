using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTwoCanvas : MonoBehaviour {

    public GameObject m_secondPhaseScreen;
    private GameObject m_secondPhaseInstance;
    public Vector3 m_secondScreenSpawnPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "hand")
        {
            m_secondPhaseInstance = Instantiate(m_secondPhaseScreen, m_secondScreenSpawnPosition, Quaternion.Euler(0, 180, 0));
        }
        
    }
}
