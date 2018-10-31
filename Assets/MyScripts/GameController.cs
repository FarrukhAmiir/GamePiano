using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
   
    public GameObject[] Scenerios;
    public GameObject Completion, RightImg, WrongImg, effects;
    public Text count;
    int index = 0;
    TestSound sound;
    // Use this for initialization
    void Start () {
        sound = GameObject.Find("SoundManager").GetComponent<TestSound>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnNextClick()
    {
        if(EventSystem.current.currentSelectedGameObject.tag == "GoodFreind")
        {
            StartCoroutine(NextScreen());

        }
        else
            StartCoroutine(WrongScreen());

    }

    IEnumerator NextScreen()
    {
        sound.PlaySounds("Excellent");
        sound.PlaySounds("Applause");
        effects.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = new Color32(29,177,0,255);
        EventSystem.current.currentSelectedGameObject.GetComponent<ITweenMagic>().enabled = false;
        EventSystem.current.currentSelectedGameObject.GetComponent<iTween>().enabled = false;
        index++;
        if(index == 7)
        {
            yield return new WaitForSeconds(1.2f);
            Completion.SetActive(true);
        }
    }


    IEnumerator WrongScreen()
    {
        sound.PlaySounds("Try Again");
        WrongImg.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        WrongImg.SetActive(false);
    }
    public void OnClick(string name)
    {
        if (name == "Complete")
        {
            sound.ClickSound("ClickSound");
            SceneManager.LoadScene("MainMenu");
        }

        
    }

   

    

}
