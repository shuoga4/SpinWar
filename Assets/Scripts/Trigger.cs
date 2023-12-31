using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    /*
     * 求められる挙動
     * ぶつかったときに両者を飛ばすような挙動
     * addforceのimpulseあたりがいいか
     */
    // Start is called before the first frame update
    [SerializeField] private float explode = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        //otherとの位置の差の取得、それを逆向きにimpulseで放出する？
        //両方飛ばすからこのスクリプトはどちらかのみアタッチする
        var diff = transform.position - other.transform.position;
        var amp = diff * explode;
        var oppo = amp * -1;
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<Rigidbody>().AddForce(amp, ForceMode.Impulse);
            other.gameObject.GetComponent<Rigidbody>().AddForce(oppo, ForceMode.Impulse);
        }
        /*
         * パスしない。独楽をブレンダーからインポートしたあと、そのメッシュが丸のものに対して四角で届いたので、SAコリだ―を利用して
         * ヒットボックスを確認したところ、どうやら間違っていたらしく、そのあとプレイヤーを全部のオブジェクトにつけたり、というかトリガーが発生しているのかもわからない
         * とりあえずトリガーが発生しているか見よう、やっぱりだめだった。原因としては、メッシュが親オブジェクトにないためトリガースクリプトがうまく動いていない可能性あり
         * メッシュの位置が複雑、トリガーの発生条件はコリだ―が必須なのに親にない、子につけても意味ない←ｲﾏｺｺ
         * 親にトリガーしてもそもそもメッシュないから全く動かなさそう。
         * コリダ―をつかわない衝突方法を考えるか、メッシュの親オブジェクトのうまい貼り方をブレンダーとともに考えるか
         * もしくはプロビルダーつかってユニティで完結するか
         * 
         * メッシュを親につけて解決
         * 
         * 
         * 
         * triggerで起動したため物体同士がぶつからないというか、そもそもrbあたりの関係で透過させることが当然のようになっている
         * 
         * 
         */
    }
}
