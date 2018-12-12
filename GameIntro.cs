using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameIntro : MonoBehaviour {

    //public Text m_Text;
    //private bool m_IsLerping = false;
    //public GameObject[] m_introCanvases;
    private bool m_nextScreenCalled = false;

    public GameObject screenOne;
    public GameObject screenTwo;
    public GameObject screenThree;
    public Vector3 m_screenSpawnPosition;
    private GameObject firstScreen;
    private GameObject secondScreen;
    private GameObject thirdScreen;

    public GameObject[] m_Screens;

    private GameObject m_InstancedScreen;
    private int m_ScreenIndex; //what screen are we currently at

	// Use this for initialization
	void Start () {
        m_ScreenIndex = 0;
        //m_introCanvases = GameObject.FindGameObjectsWithTag("IntroCanvas");
        /*m_introCanvases[0] = GameObject.Find("IntroCanvas1");
        m_introCanvases[1] = GameObject.Find("IntroCanvas2");
        m_introCanvases[2] = GameObject.Find("IntroCanvas3");*/
        m_InstancedScreen = Instantiate(m_Screens[m_ScreenIndex], m_screenSpawnPosition, Quaternion.Euler(new Vector3(0, 180, 0)));
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            GotoNextScreen();
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
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "hand")
        {
            GotoNextScreen();
        }


        /*
        //m_IsLerping = true;
        m_nextScreenCalled = true;
        if(screenOne.activeSelf)
        {
            //GoSecondScreen();
            secondScreen = Instantiate(screenTwo, m_screenSpawnPosition, Quaternion.Euler(new Vector3(0, 180, 0)));
            m_nextScreenCalled = false;
            Destroy(firstScreen);
        }*/
    }

    private void GotoNextScreen()
    {
        m_ScreenIndex++;

        if (m_ScreenIndex >= m_Screens.Length)
        {
            return;
        }

        if (m_InstancedScreen != null)
        {
            Destroy(m_InstancedScreen);
            m_InstancedScreen = null;
        }

        m_InstancedScreen = Instantiate(m_Screens[m_ScreenIndex], m_screenSpawnPosition, Quaternion.Euler(new Vector3(0, 180, 0)));
    }

    /*public void GoSecondScreen()
    {
        secondScreen = Instantiate(screenTwo, m_screenSpawnPosition, Quaternion.Euler(new Vector3(0, 180, 0)));
        m_nextScreenCalled = false;
        Destroy(firstScreen);
    }

    public void GoThirdScreen()
    {
        thirdScreen = Instantiate(screenThree, m_screenSpawnPosition, Quaternion.Euler(new Vector3(0, 180, 0)));
        m_nextScreenCalled = false;
        Destroy(secondScreen);
    }*/
}
