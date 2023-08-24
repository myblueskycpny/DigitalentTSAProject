using UnityEngine;

public class MusicController : MonoBehaviour
{
    public static MusicController instance { get; set; }
    [HideInInspector]
    public AudioSource music;

    void Awake()
    {
        music = GetComponent<AudioSource>();

        DontDestroyOnLoad(this);

        if (instance == null)
        {
            instance = this;;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    public void Mute()
    {
        if(music.mute == false)
        {
            music.mute = true;
        }
        else
        {
            music.mute = false;
        }
    }
}
