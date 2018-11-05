using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Sound : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{


   

    AudioSource audio;
    // Use this for initialization
    public GameObject buttonPrefab;
    GameObject prefabInstance;
        public Sprite UnPressed,Pressed;
    public void OnMouseOver()
    {
        //OnClick();
        ////do stuff
    }
    void Start () {
        //CreateInstances();
       
    }
	
	// Update is called once per frame
	void Update () {

       
    }
    public void OnClick()
    {
        audio = transform.GetComponent<AudioSource>();
        audio.enabled = true;
        audio.Play();
        
    }
   
    public void CreateInstances()
    {
        for (int i = 0; i < 10; ++i)
        {
            prefabInstance = Object.Instantiate(buttonPrefab);
            prefabInstance.transform.parent = GameObject.Find("Whites").transform;
            Button button = prefabInstance.GetComponent<Button>();
            button.onClick.AddListener(() => { OnButtonClicked(i); });
        }
    }

    public void OnButtonClicked(int buttonIndex)
    {
       
        transform.GetComponent<Image>().sprite = UnPressed;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       
        transform.GetComponent<Image>().sprite = Pressed;
        OnClick();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
       
        transform.GetComponent<Image>().sprite = UnPressed;

    }

}
