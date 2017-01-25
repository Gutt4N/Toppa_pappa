using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Titletouch : MonoBehaviour
{

    private Touch touch;

    //title表示/非表示
    public GameObject title1;
    public GameObject title2;
    public GameObject text;

    //wait time
    float stopTime;
    //timerflag
    bool timerflag;

    ScreenFadeManager fadeManager;

    // Use this for initialization
    void Start()
    {
        title2.SetActive(false);
        stopTime = 0;
        timerflag = false;


        // シングルトンインスタンスを取得する
        fadeManager = ScreenFadeManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                // タッチ開始
                title1.SetActive(false);
                title2.SetActive(true);
                text.SetActive(false);
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                // moved
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                // ended
            }
        }

        //Debug
        if (Input.GetMouseButton(0))
        {
            title1.SetActive(false);
            title2.SetActive(true);
            text.SetActive(false);

            timerflag = true;
        }

        //timerflagがtrueになったらストップタイマーが動きだす
        if (timerflag == true)
        {
            stopTime++;
        }
        //２秒後にScene遷移
        if (stopTime >= 120)
        {
            

            fadeManager.FadeOut(1.0f, Color.black, () => { 
                //test
                SceneManager.LoadScene("StageSelect");
            });
         

        }
    }
}