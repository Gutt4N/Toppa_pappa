using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class backtitle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                SceneManager.LoadScene("StageSelect");
            }
        }
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("StageSelect");
        }

    }
}
