using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour {

    //clear画像取得
    public GameObject clear;
    //おじさん笑顔取得
    public GameObject[] ozisan = new GameObject[7];
    //移動座標格納
    float posx, posy;

    //Scene遷移
    ScreenFadeManager fadeManager;

    // Use this for initialization
    void Start () {
        // シングルトンインスタンスを取得する
        fadeManager = ScreenFadeManager.Instance;

        for (int i = 0; i < 7; i++)
        {
            posx = Random.Range(0, 3);
            posy = Random.Range(0, 50);
            ozisan[i].transform.Rotate(0, 0, 0);
            ozisan[i].transform.position = new Vector3(posx, posy, 0);
        }
    }

    // Update is called once per frame
    void Update () {

        //タッチ処理
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                fadeManager.FadeOut(1.0f, Color.black, () =>
                {
                    //test
                    SceneManager.LoadScene("StageSelect");
                });
            }
        }

        //Debug
        if (Input.GetMouseButton(0))
        {
            fadeManager.FadeOut(1.0f, Color.black, () =>
            {
                //test
                SceneManager.LoadScene("StageSelect");
            });
        }
    }
}
