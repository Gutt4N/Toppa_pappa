using UnityEngine;
using System.Collections;

public class area1Wall2 : MonoBehaviour {

    public GameObject target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        iTween.MoveTo(target, iTween.Hash("x", -33, "time", 3, "loopType", iTween.LoopType.pingPong));
    }
}
