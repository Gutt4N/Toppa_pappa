using UnityEngine;
using System.Collections;

public class wall2 : MonoBehaviour {

    //gameobject取得
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;

    //タイマー
    private int timer;
    //ブロックの方向切り替えフラグ
    private bool blockFrag;

    // Use this for initialization
    void Start () {
        timer = 0;
        blockFrag = false;
    }
	
	// Update is called once per frame
	void Update () {
        //timerカウントアップ
        timer++;
        //timerが一定量進んだ後の処理
        if (timer >= 220)
        {
            //方向切り替え
            blockFrag = false;
            //timerリセット
            timer = 0;
        }
        else if (timer >= 110)
        {
            //方向切り替え
            blockFrag = true;
        }

        //move切り替え
        if (blockFrag == false)
        {
            iTween.MoveBy(target1, iTween.Hash("y", -30, "time", 1.5, "easeType", iTween.EaseType.linear));
            iTween.MoveBy(target2, iTween.Hash("y", 30, "time", 1.5, "easeType", iTween.EaseType.linear));
            iTween.MoveBy(target3, iTween.Hash("y", -30, "time", 1.5, "easeType", iTween.EaseType.linear));
            iTween.MoveBy(target4, iTween.Hash("y", 30, "time", 1.5, "easeType", iTween.EaseType.linear));
        }
        else if (blockFrag == true)
        {
            iTween.MoveBy(target1, iTween.Hash("y", 30, "time", 1.5, "easeType", iTween.EaseType.linear));
            iTween.MoveBy(target2, iTween.Hash("y", -30, "time", 1.5, "easeType", iTween.EaseType.linear));
            iTween.MoveBy(target3, iTween.Hash("y", 30, "time", 1.5, "easeType", iTween.EaseType.linear));
            iTween.MoveBy(target4, iTween.Hash("y", -30, "time", 1.5,"easeType", iTween.EaseType.linear));
        }

       
        
        
       
    }
}
