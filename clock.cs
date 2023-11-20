using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class clock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;
    // Start is called before the first frame update
    void Start()
    {
        //Clockの子オブジェクトの2,3,4番目(長針，短針，秒針)を取得
        hourHand = transform.GetChild(1);
        minuteHand = transform.GetChild(2);
        secondHand = transform.GetChild(3);
    }
    
    //DateTime time = DateTime.Now;
    //private float hour;
    //private float minute;
    //private float second;
    // Update is called once per frame
    void Update()
    {
         // 現在の時間を取得
        float hours = System.DateTime.Now.Hour % 12;
        float minutes = System.DateTime.Now.Minute;
        float seconds = System.DateTime.Now.Second;

        // 各針の回転角度を計算
        float hourRotation = hours * 30f + (minutes / 60f) * 30f;
        float minuteRotation = minutes * 6f + (seconds / 60f) * 6f;
        float secondRotation = seconds * 6f;


        // 各針を回転
        hourHand.rotation = Quaternion.Euler(hourRotation,0, 0);
        minuteHand.rotation = Quaternion.Euler(minuteRotation,0, 0);
        secondHand.rotation = Quaternion.Euler(secondRotation,0, 0);
    }
}
