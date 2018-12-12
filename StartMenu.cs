using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

    public StartMenu m_singleton;
	// Use this for initialization
	void Start () {
        m_singleton = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "singlePlayer")
        {
            GetComponent<MeshRenderer>().material.color = new Color32(255, 248, 175, 255);
            SceneManager.LoadScene("Main");
        }

       if(gameObject.tag == "multiPlayer")
        {
            GetComponent<MeshRenderer>().material.color = new Color32(255, 248, 175, 255);
            SceneManager.LoadScene("MultiPlayerRoom");
        }
    }
}
