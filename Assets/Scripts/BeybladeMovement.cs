using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeybladeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    /*
     * 求められる挙動
     * 独楽の動きをする
     * こまの動きとは
     * 加速度で操作する
     * レバーを倒し続けると、最初は遅いけどだんだん早くなるような仕様
     * 力を加え続けるスタンスのほうが、velocityより良さそう。
     * 
     *　ぶつかったとき処理は別スクリプトで
     * 
     * 回ってる感の実装
     */
    public GameObject focus;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var diff = focus.transform.position - transform.position;
        var onediff = diff / diff.magnitude;
        var rb = GetComponent<Rigidbody>();
        rb.AddForce(onediff, ForceMode.Force);
    }
 
}
