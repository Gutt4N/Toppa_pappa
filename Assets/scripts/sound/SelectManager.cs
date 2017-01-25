using UnityEngine;
using System.Collections;

public class SelectManager : MonoBehaviour {

    //BGM
    private AudioSource sound1;
    //touch
    private AudioSource sound2;

    // Use this for initialization
    void Start () {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        sound1 = audioSources[0];
        sound2 = audioSources[1];
    }
	
	// Update is called once per frame
	void Update () {
        //音楽loop再生
        if (!sound1.isPlaying)
        {
            sound1.Play();
        }

        //画面タッチされたら音楽ストップflagを立ち上げる
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                
                //touch音再生
                sound2.Play();
            }
        }
        //Debug
        if (Input.GetMouseButton(0))
        {
            //touch音再生
            sound2.Play();
        }
    }
}