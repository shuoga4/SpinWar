using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLeverMovement : MonoBehaviour
{
    // Start is called before the first frame update
    /*
     * 求められる挙動
     * ミッドにひたすらより続けるレバーの動かし方
     * それと抽選でプレイヤーにも寄る動き
     * 
     */
    public GameObject enemyBayblade;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var diff = new Vector3(0, 0, 0) - enemyBayblade.transform.position;
        var onediff = diff / diff.magnitude;
        var leverdiff = onediff * 3;
        var result = leverdiff + new Vector3(-38,0,0);
        result.y = 0.1f;
        transform.position = result;
    }
}
