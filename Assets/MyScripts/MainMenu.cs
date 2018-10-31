using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    TestSound sounds;
    public GameObject settingsOff, SettingsOn, musicOn, MusicOff, SoundOn, SoundOff;
    // Use this for initialization
    void Start()
    {
        sounds = GameObject.Find("SoundManager").GetComponent<TestSound>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick(string name)
    {
        if (name == "Setting")
        {
            GameObject.Find("Bar").GetComponent<ITweenMagic>().enabled = true;
            SettingsOn.SetActive(false);
            settingsOff.SetActive(true);
        }

        else if (name == "SettingsOff")
        {
            GameObject.Find("Bar").transform.localScale = new Vector3(0, 1, 1);
            GameObject.Find("Bar").GetComponent<ITweenMagic>().enabled = false;
            SettingsOn.SetActive(true);
            settingsOff.SetActive(false);
        }

        else if (name == "MusicOn")
        {
            sounds.MuteMusic("Intro Theme");
            MusicOff.SetActive(true);
            musicOn.SetActive(false);
        }

        else if (name == "MusicOff")
        {
            sounds.UnMuteMusic("Intro Theme");
            musicOn.SetActive(true);
            MusicOff.SetActive(false);
        }

        else if (name == "SoundOn")
        {
            sounds.MuteMusic("258269__jcallison__mouth-pop");
            sounds.MuteMusic("ClickSound");
            SoundOn.SetActive(false);
            SoundOff.SetActive(true);
        }

        else if (name == "SoundOff")
        {
            sounds.UnMuteMusic("258269__jcallison__mouth-pop");
            sounds.UnMuteMusic("ClickSound");
            SoundOn.SetActive(true);
            SoundOff.SetActive(false);
        }
        else if (name == "Play")
        {
            sounds.ClickSound("ClickSound");
            SceneManager.LoadScene(1);

        }
    }
}
