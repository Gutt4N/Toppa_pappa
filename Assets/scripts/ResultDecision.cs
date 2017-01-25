using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResultDecision : MonoBehaviour
{

    //Player取得
    public GameObject player;
    Player obj;

    //Scene遷移
    ScreenFadeManager fadeManager;

    // Use this for initialization
    void Start()
    {
        obj = player.GetComponent<Player>();

       
    }

    // Update is called once per frame
    void Update()
    {

        //0以下になったらゲームオーバー
        if (obj.HP == 0)
        {
            SceneManager.LoadScene("StageOver");
        }
        //ゴールフラグがたてばクリア

        if (obj.goalflag == true)
        {
            SceneManager.LoadScene("StageClear");
        }
    }
}
