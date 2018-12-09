using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameIntro : MonoBehaviour {

    //public Text m_Text;
    public GameObject[] m_introCanvases;
    //private bool m_IsLerping = false;
    private bool m_nextScreenCalled = false; 

	// Use this for initialization
	void Start () {
        m_introCanvases = GameObject.FindGameObjectsWithTag("IntroCanvas");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            //m_IsLerping = true;
            m_nextScreenCalled = true;
        }

		/*if (m_IsLerping == true)
        {
            float currentTextAlpha = m_Text.color.a;

            float newTextAlpha = Mathf.Lerp(currentTextAlpha, 0, Time.deltaTime);

            m_Text.color = new Color(m_Text.color.r, m_Text.color.g, m_Text.color.b, newTextAlpha);

            if (m_Text.color.a <= 0.01)
            {
                //lerp is done
                m_IsLerping = false;
            }
        }*/

        if(m_nextScreenCalled == true)
        {

        }

	}

    public void OnTriggerEnter(Collider other)
    {
        //m_IsLerping = true;
        m_nextScreenCalled = true;
    }
}
