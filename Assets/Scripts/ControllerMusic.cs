using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMusic : MonoBehaviour
{
    public GameObject MuteButt;
    public GameObject unMuteButt;
    void Start()
    {
        Cursor.visible = true;
        if(MusicController.instance.music.mute == false)
        {
            MuteButt.SetActive(true);
            unMuteButt.SetActive(false);
        }
        else
        {
            MuteButt.SetActive(false);
            unMuteButt.SetActive(true);
        }
    }


    void Update()
    {
        
    }
    public void Mute()
    {
        MusicController.instance.Mute();
    }
}
