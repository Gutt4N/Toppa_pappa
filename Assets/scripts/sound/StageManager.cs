using UnityEngine;
using System.Collections;

public class StageManager : MonoBehaviour
{

    //BGM
    private AudioSource sound1;

    // Use this for initialization
    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        sound1 = audioSources[0];
    }

    // Update is called once per frame
    void Update()
    {

        //音楽loop再生
        if (!sound1.isPlaying)
        {
            sound1.Play();
        }

    }
}
