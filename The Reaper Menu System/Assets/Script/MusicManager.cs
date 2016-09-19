using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour {
    public AudioSource musicTrack;
    public Slider sound, music, ambitientSound;
	// Use this for initialization
	void Start () {
        
        music.value = PlayerPrefs.GetFloat("musicValue");
        sound.value = PlayerPrefs.GetFloat("soundValue");
        ambitientSound.value = PlayerPrefs.GetFloat("ambientValue");
        
	}
	
	// Update is called once per frame
	void Update () {

        musicTrack.volume = music.value;


        Debug.Log(music.value);
	}

    //void OnGUI()
    //{
    //    if (currentSlider != null)
    //    {
    //        Event e = Event.current;
    //        if (e.isMouse)
    //        {
    //            if (currentSlider == music)
    //            {
    //                soundTRACK.volume = music.value;
    //            }
    //        }
    //    }
    //}

    //public void changeSlider(Slider clicked)
    //{
    //    currentSlider = clicked;
    //}

    public void savedKeys()
    {
        PlayerPrefs.SetFloat("soundValue", sound.value);
        PlayerPrefs.SetFloat("musicValue", music.value);
        PlayerPrefs.SetFloat("ambientValue", ambitientSound.value);

        PlayerPrefs.Save();

    }
}
