using UnityEngine;

//   背景音樂  鬼音樂  陷阱音樂

public class DJMusicBox : MonoBehaviour
{

    //儲存背景音樂的AudioSource Component
    private AudioSource bgMusicAudioSource;

    void OnEnable()
    {
        //在所有Game Object中找尋Background Music
        bgMusicAudioSource = GameObject.FindGameObjectWithTag("Background Music").GetComponent<AudioSource>();

        //暫停音樂
        bgMusicAudioSource.Pause();
    }

    void OnDisable()
    {
        //繼續音樂
        bgMusicAudioSource.UnPause();
    }

}

//E
