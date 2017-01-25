using UnityEngine;
using System.Collections;
using DG.Tweening;

public class TitleBlink : MonoBehaviour
{
    private float nextTime;
    public float interval = 1.0f;	// 点滅周期
    public Renderer Obj;

    void Start()
    {
        nextTime = Time.time;
    }
    void Update()
    {
        if (Time.time > nextTime)
        {
            Obj.enabled = !Obj.enabled;

            nextTime += interval;
        }
    }
}