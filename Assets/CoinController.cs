using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんと物体の距離
    private float difference;

    // Use this for initialization
    void Start()
    {
        //回転を開始する角度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);

        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //回転
        this.transform.Rotate(0, 3, 0);

        //Unityちゃんと物体の位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;
        if (difference > 10)
        {
            Destroy(this);
        }
    }
}
