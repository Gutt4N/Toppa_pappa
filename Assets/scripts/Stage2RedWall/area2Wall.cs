using UnityEngine;
using System.Collections;

public class area2Wall : MonoBehaviour {

    public GameObject target;
    public GameObject target2;
    public GameObject target3;
    public GameObject target4;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        iTween.MoveBy(target, iTween.Hash("x", 20,"y",10, "time", 2, "loopType", iTween.LoopType.pingPong));
        iTween.MoveBy(target2, iTween.Hash("x", 20, "y", -10, "time", 2, "loopType", iTween.LoopType.pingPong));
        iTween.MoveBy(target3, iTween.Hash("x", -20, "y", -10, "time", 2, "loopType", iTween.LoopType.pingPong));
        iTween.MoveBy(target4, iTween.Hash("x", -20, "y", 10, "time", 2, "loopType", iTween.LoopType.pingPong));
    }
}
