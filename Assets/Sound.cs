using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Sound : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{


   

    AudioSource audio;
    // Use this for initialization
    
    public Sprite UnPressed,Pressed;
    public void OnMouseOver()
    {
        
    }
    void Start () {
       
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
