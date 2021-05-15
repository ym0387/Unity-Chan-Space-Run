using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    //オブジェクトの速度
    public float speed = 0.05f;

    //オブジェクトの横移動の最大距離
    public float max_x = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //フレーム毎スピードの値分だけx軸方向に移動
        this.gameObject.transform.Translate(speed, 0, 0);

        //Transformの値が一定値を超えたときに向きを反対にする
        if (this.gameObject.transform.position.x > max_x ||
            this.gameObject.transform.position.x < -(max_x))
        {
            speed *= -1;
        }
    }
}
