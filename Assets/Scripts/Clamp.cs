using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clamp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _maxRadius = 3;
    private Vector3 mid = new Vector3(45,0,0); // 敵のとき変える
    void Start()
    {
       
    }

    // Update is called once per frame
    /*
     * 期待される挙動
     * 45,0,0からベクトル長で3しか動けないようにする
     * 例えば原点からなら0,0,0だから、ベクトル長3といっても簡単
     * そうか、midを0として現在のposがどれぐらい動いているかだから
     * diff = pos - mid
     * clamp(diff,3)で良いわけだ
     * 
     */
    void Update()
    {
        var pos = transform.position; // これが飛んでいく、クランプして抑える
        var diff = pos - mid;
        var clamp = Vector3.ClampMagnitude(diff, _maxRadius);
        var result = clamp + mid;
        transform.position = result;
    }
}
