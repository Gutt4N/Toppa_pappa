using UnityEngine;
using System.Collections;

public class area1Wall1 : MonoBehaviour {

    public GameObject target;
    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update ()
    {
        // iTween.MoveTo(target, iTween.Hash("x", 3,"time", 3.0f,"looptype", iTween.LoopType.loop));

        iTween.MoveTo(target, iTween.Hash( "x", 33,"time",3,"loopType", iTween.LoopType.pingPong));
    }
}
