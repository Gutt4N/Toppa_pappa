using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{

    //BGM
    private AudioSource sound1;
    //husuma
    private AudioSource sound2;
    //touch
    private AudioSource sound3;

    //BGMフラグ
    private bool bgmFlag;

    // Use this for initialization
    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        sound1 = audioSources[0];
        sound2 = audioSources[1];
        sound3 = audioSources[2];
        bgmFlag = false;
    }

    // Update is called once per frame
    void Update()
    {

        //音楽loop再生
        if (!sound1.isPlaying && bgmFlag == false)
        {
            sound1.Play();
        }
        //BGMフラグがfalseだったら音楽ストップ
        if (bgmFlag == true)
        {
            sound1.Stop();
        }


        //画面タッチされたら音楽ストップflagを立ち上げる
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                //touch音再生
                sound3.Play();
                //ふすまopen再生
                sound2.Play();
                bgmFlag = true;
            }
        }

        //Debug
        if (Input.GetMouseButton(0))
        {
            //touch音再生
            sound3.Play();
            //ふすまopen再生
            sound2.Play();
            bgmFlag = true;
        }
    }
}
