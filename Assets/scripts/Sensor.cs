using UnityEngine;
using System.Collections;

public class Sensor : MonoBehaviour {

    //player
    public GameObject player;
    //homing
    public GameObject homingsensor;
    //homing speed
    public float movespeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //playerをセンサーがホーミングする
        homingsensor.transform.position = Vector2.MoveTowards(homingsensor.transform.position, new Vector2(player.transform.position.x, player.transform.position.y), movespeed * Time.deltaTime);
    }
}
