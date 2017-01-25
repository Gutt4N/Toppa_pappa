using UnityEngine;
using System.Collections;

public class PlayCamera : MonoBehaviour {

    public GameObject Player;
    public GameObject mainCamera;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        mainCamera.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z-200);

    }
}
