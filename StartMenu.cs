using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
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

        else if(gameObject.tag == "multiPlayer")
        {
            GetComponent<MeshRenderer>().material.color = new Color32(255, 248, 175, 255);
            Debug.Log("Loading Network Hud");
            SceneManager.LoadScene("NetworkLobby");
        }
        Debug.Log("End of OnTriggerEnter");
    }
}
