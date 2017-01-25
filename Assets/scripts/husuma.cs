using UnityEngine;
using System.Collections;

public class husuma : MonoBehaviour {

    //gameobject取得
    public GameObject husuma1;
    public GameObject husuma2;
    public GameObject husuma3;
    public GameObject husuma4;
    public GameObject husuma5;
    public GameObject husuma6;
    public GameObject husuma7;
    public GameObject husuma8;
    public GameObject husuma9;
    public GameObject husuma10;

    //playerのobject取得
    public GameObject player;
    Player obj;

    //SE
    private AudioSource sound1;

    // Use this for initialization
    void Start () {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        sound1 = audioSources[0];

        obj = player.GetComponent<Player>();
        //偶数のふすまを最初消す
        husuma2.SetActive(false);
        husuma4.SetActive(false);
        husuma6.SetActive(false);
        husuma8.SetActive(false);
        husuma10.SetActive(false);        
    }
	
	// Update is called once per frame
	void Update () {

        //HPに応じてふすまを処理する
        if (obj.HP >=16)
        {
            //最初のふすまを開ける
            husuma1.SetActive(false);
            husuma2.SetActive(true);
            //通路ふすまを開ける
            husuma3.SetActive(false);
            husuma4.SetActive(true);

        }
        else if(obj.HP <= 16)
        {

            //最初のふすまを閉める
            husuma1.SetActive(true);
            husuma2.SetActive(false);
            //通路ふすまを閉める
            husuma3.SetActive(true);
            husuma4.SetActive(false);
        }


        //opencountとHPに応じてふすまを開ける
        if (obj.HP >= 21&& obj.husumacheckcount == 1)
        {
            //第３チェックポイントにいくふすまを開ける
            husuma5.SetActive(false);
            husuma6.SetActive(true);
            //通路のふすまを開ける
            husuma7.SetActive(false);
            husuma8.SetActive(true);

        }
        else if (obj.HP <= 20&& obj.husumacheckcount == 1)
        {
            //第３チェックポイントにいくふすまを閉める
            husuma5.SetActive(true);
            husuma6.SetActive(false);
            //通路のふすまを閉める
            husuma7.SetActive(true);
            husuma8.SetActive(false);
        }

        //goalふすまを開ける
        if (obj.HP >= 21 && obj.husumacheckcount == 2)
        {
            //第３チェックポイントにいくふすまを開ける
            husuma9.SetActive(false);
            husuma10.SetActive(true);
        }
        else if (obj.HP <= 20 && obj.husumacheckcount == 2)
        {
            //第３チェックポイントにいくふすまを閉める
            husuma9.SetActive(true);
            husuma10.SetActive(false);
        }


        //一度通ったふすまは二度と通らない
        if (obj.husumacheckcount == 1|| obj.husumacheckcount == 2)
        {
            //最初のふすまを閉める
            husuma1.SetActive(true);
            husuma2.SetActive(false);
            //通路ふすまを閉める
            husuma3.SetActive(true);
            husuma4.SetActive(false);
        }
        if (obj.husumacheckcount == 2)
        {
            //第３チェックポイントにいくふすまを閉める
            husuma5.SetActive(true);
            husuma6.SetActive(false);
            //通路のふすまを閉める
            husuma7.SetActive(true);
            husuma8.SetActive(false);
        }

        //sound
        if(husuma2.activeInHierarchy||
            husuma4.activeInHierarchy ||
            husuma6.activeInHierarchy ||
            husuma8.activeInHierarchy ||
            husuma10.activeInHierarchy)
        {
            sound1.Play();
        }
        else if (!husuma1.activeInHierarchy ||
           !husuma3.activeInHierarchy ||
           !husuma5.activeInHierarchy ||
           !husuma7.activeInHierarchy ||
           !husuma9.activeInHierarchy)
        {
            sound1.Play();
        }
    }
}
