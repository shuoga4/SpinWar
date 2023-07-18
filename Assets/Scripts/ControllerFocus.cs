using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerFocus : MonoBehaviour
{
    // Start is called before the first frame update
    /*
     * 期待される挙動
     * カーソルの動きを受けてステージの上を動き、コマが向かっていく方向としてフォーカスを受ける
     * まるで増幅するように挙動をする
     * cursor - mid * 定数
     * 上記.y = 定数
     * で終わりじゃね？
     */
    public GameObject lever;
    [SerializeField] private float amplificatenum = 6;
    [SerializeField] private Vector3 mid = new Vector3(45, 0, 0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var fromWP = (lever.transform.position - mid) * amplificatenum; // 敵のとき変える
        fromWP.y = 1;
        transform.position = fromWP;
    }
}
