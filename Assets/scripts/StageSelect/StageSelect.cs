using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour {

    //Scene遷移
    ScreenFadeManager fadeManager;
    //BGM
    private AudioSource sound1;

    // Use this for initialization
    void Start () {
        // シングルトンインスタンスを取得する
        fadeManager = ScreenFadeManager.Instance;

        AudioSource[] audioSources = GetComponents<AudioSource>();
        sound1 = audioSources[0];
    }
	
	// Update is called once per frame
	void Update () {

    }

   public void onClick1()
    {
        fadeManager.FadeOut(1.0f, Color.black, () => {
            //test
            SceneManager.LoadScene("Stage1");
        });

        //音楽loop再生
        if (!sound1.isPlaying)
        {
            sound1.Play();
        }
    }
    public void onClick2()
    {
        fadeManager.FadeOut(1.0f, Color.black, () => {
            //test
            SceneManager.LoadScene("Stage2");
        });

        //音楽loop再生
        if (!sound1.isPlaying)
        {
            sound1.Play();
        }
    }
    public void onClick3()
    {
        fadeManager.FadeOut(1.0f, Color.black, () => {
            //test
            SceneManager.LoadScene("Stage3");
        });

        if (!sound1.isPlaying)
        {
            sound1.Play();
        }
    }
    public void onClick4()
    {
        fadeManager.FadeOut(1.0f, Color.black, () => {
            //test
            SceneManager.LoadScene("StageSelect");
        });

        if (!sound1.isPlaying)
        {
            sound1.Play();
        }
    }
    public void onClick5()
    {
        fadeManager.FadeOut(1.0f, Color.black, () => {
            //test
            SceneManager.LoadScene("Title");
        });

        if (!sound1.isPlaying)
        {
            sound1.Play();
        }
    }
    public void onClick6()
    {
        fadeManager.FadeOut(1.0f, Color.black, () => {
            //test
            SceneManager.LoadScene("asobikata");
        });

        if (!sound1.isPlaying)
        {
            sound1.Play();
        }
    }
}
