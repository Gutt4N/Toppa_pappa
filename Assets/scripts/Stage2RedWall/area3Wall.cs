using UnityEngine;
using System.Collections;

public class area3Wall : MonoBehaviour {

    public GameObject target;
    private int timer; //block move timer
    private bool blockFrag; //block move frag

    // Use this for initialization
    void Start () {
        timer = 0;
        blockFrag = false;
	}
	
	// Update is called once per frame
	void Update () {

        timer++;

        if(timer >= 240)
        {
            blockFrag = false;
            timer = 0;
        }
        else if(timer >= 120)
        {
            blockFrag = true;
        }

        //下にmove
        if(blockFrag==false)
        {
            iTween.MoveBy(target, iTween.Hash("y", -10, "time", 1, "easeType", iTween.EaseType.linear));
        }
        else if(blockFrag==true)
        {
            iTween.MoveBy(target, iTween.Hash("y", 10, "time", 1, "easeType", iTween.EaseType.linear));
        }
        

    }
}
