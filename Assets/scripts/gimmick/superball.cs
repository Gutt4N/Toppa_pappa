using UnityEngine;
using System.Collections;

public class superball : MonoBehaviour
{
    //count取得
    public GameObject countdown;
    CountDown timer;

    //rigidbody取得用
    Rigidbody2D rb;
    //gameobject取得
    public CircleCollider2D ball;
    //方角指定用
    private Vector2 dir;
    //移動速度
    public float movespeed = 2.0f;

    //ballstartflag
    private bool startball;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timer = countdown.GetComponent<CountDown>();
        startball = false;
    }

    // Update is called once per frame
    void Update()
    {

        //一度のみ通る
        if(timer.starflag==true&&startball==false)
        {
            //移動処理
            float x = Random.Range(-5, 5);
            float y = Random.Range(-5, 5);
            dir = new Vector2(x, y);
            startball = true;
        }

        rb.transform.Translate(dir * movespeed);
    }

    //壁にぶつかったら方角を変更
    void OnCollisionStay2D(Collision2D coll)
    {
        //壁との衝突判定
        if (coll.gameObject.tag == "wall")
        {
            //移動処理
            float x = Random.Range(-5, 5);
            float y = Random.Range(-5, 5);
            dir = new Vector2(x, y);
        }
    }
    //superball同士のあたり判定
    void OnCollisionEnter2D(Collision2D coll)
    {
        //壁との衝突判定
        if (coll.gameObject.tag == "superball"|| coll.gameObject.tag == "Player")
        {
            //移動処理
            float x = Random.Range(-5, 5);
            float y = Random.Range(-5, 5);
            dir = new Vector2(x, y);
        }
        //壁との衝突判定
        if (coll.gameObject.tag == "wall")
        {
            //移動処理
            float x = Random.Range(-5, 5);
            float y = Random.Range(-5, 5);
            dir = new Vector2(x, y);
        }
    }
}
