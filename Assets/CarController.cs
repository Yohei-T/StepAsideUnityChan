﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    private GameObject unitychan;
    //Unityちゃんと物体の距離
    private float difference;

    // Use this for initialization
    void Start ()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }
	
	// Update is called once per frame
	void Update () {
        //Unityちゃんと物体の位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;
        if (difference > 10)
        {
            Destroy(this);
        }
    }
}
