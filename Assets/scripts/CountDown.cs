using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {
    //count表示
    public GameObject count1;
    public GameObject count2;
    public GameObject count3;

    //count切り替えタイマー
    private double timer;
    //startflag
    public bool starflag;

    // Use this for initialization
    void Start () {
        timer = 0;
        starflag = false;
        //1.2の表示は消す
        count1.SetActive(false);
        count2.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        timer += MNZTimer.Instance.deltaTime;
        //coutがなくなるまで時を止める
        if (!starflag)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }

        if (timer >= 3.0f)
        {
            //2.1を切り替え
            count1.SetActive(false);
            starflag = true;
        }
        else if(timer>=2.0f)
        {
            //2.1を切り替え
            count1.SetActive(true);
            count2.SetActive(false);
        }
        else if (timer >= 1.0f)
        {
            //2.3を切り替え
            count2.SetActive(true);
            count3.SetActive(false);
        }
       
        


         
    }
}
