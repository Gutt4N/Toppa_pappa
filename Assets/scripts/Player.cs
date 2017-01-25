using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    //移動スピード
    public float moveSpeed;
    //反発設定
    //public PhysicsMaterial2D material;
    //距離指定
    private Vector2 dir;
    //PlayerHP
    public int HP;
    private int upcounter;
    private int downcounter;
    private int downcounter2;
    //Playerの座標を保存
    private Vector2 savepos;
    //Playerの座標を保存するタイミングを決めるFlag
    private bool gethpflag;
    //husuma通過カウント
    public int husumacheckcount;
    //hp表示
    public Text hptext;
    //goalflag
    public bool goalflag;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        HP = 10;
        gethpflag = false;
        //ふすまを通過する時にカウントを上げる
        husumacheckcount = 0;
        //HPを上げるときのカウンター
        upcounter = 0;
        //HPを下げるときのカウンター
        downcounter = 0;
        downcounter2 = 0;
        //goalflag
        goalflag = false;
    }

    // Update is called once per frame
    void Update()
    {
        //加速度センサー取得
        Vector2 acc = Input.acceleration;
        dir.x = acc.x;
        dir.y = acc.y;
        //加速度センサーで動かす
        if (dir.sqrMagnitude > 1)
        {
            dir.Normalize();
        }

        dir *= Time.deltaTime;

        transform.Translate(dir * moveSpeed);

        // debug 左右
        float x = Input.GetAxisRaw("Horizontal");

        // debug　上下
        float y = Input.GetAxisRaw("Vertical");

        // 移動する向きを求める
        dir = new Vector2(x, y).normalized;

        // 移動する向きとスピードを代入する
        rb.velocity = dir * moveSpeed;

        //止まっていたら１フレームだけ起こす
        rb.WakeUp();

        //playerの座標を保存
        if(gethpflag==false)
        {
            savepos.x = rb.transform.position.x;
            savepos.y = rb.transform.position.y;
            gethpflag = true;
        }

        //HP計算式
        if(savepos.x>rb.position.x+35|| savepos.x < rb.position.x - 35||
           savepos.y > rb.position.y + 35 || savepos.y < rb.position.y - 35)
        {
            HP++;
            gethpflag = false;
        }

        //downcounterが40を超えたときHPを１さげる
        if(downcounter>=40)
        {
            HP -= 1;
            downcounter = 0;
        }
        if (downcounter2 >= 40)
        {
            HP -= 1;
            downcounter2 = 0;
        }
        //upcounterが20を超えたときHPを１上げる
        if(upcounter>=20)
        {
            HP += 1;
            upcounter = 0;
        }

        //hp表示
        hptext.text = HP.ToString();

    }

    //superballと接触した場合
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "superball")
        {
            Vector2 pos = rb.transform.position;
            //移動処理
            float x = Random.Range(-7, 7);
            float y = Random.Range(-5, 5);
            pos.x += x;
            pos.y += y;
            rb.transform.position = pos;
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "husuma")
        {
            HP = 10;//HPを10にもどす
            husumacheckcount = 1;
        }
        if (coll.gameObject.tag == "husuma2")
        {
            HP = 10;//HPを10にもどす
            husumacheckcount = 2;
        }
        if (coll.gameObject.tag == "Goal")
        {
            goalflag = true;
        }
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        //HPDown
        if (coll.gameObject.tag == "Out")
        {
            downcounter2++;
        }
        else if (coll.gameObject.tag == "safe")
        {
            upcounter++;
        }
    }

    void OnCollisionStay2D(Collision2D coll)
    {
        //HPDown
        if (coll.gameObject.tag == "RedWall")
        {
            downcounter++;
        }
      
    }
}
