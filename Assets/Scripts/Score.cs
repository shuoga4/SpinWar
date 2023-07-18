using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    /*
     * 求められる挙動
     * 中央から一定の距離離れたらスコア
     * transform.position.magnitudeできそう
     * これが一定値超えたら、アウト
     * tag変えてどっちも見れるようにしたほうがいいかも
     * 
     * おかしい挙動
     *　このスクリプトを２つベイに設置したせいで挙動がおかしい
     *　スコアは別スクリプトで、もう一つ、どっちものオブジェにおく、範囲外判定用スクリプトを設置するべきか？
     */
    [System.NonSerialized] public int redScore = 0;
    [System.NonSerialized] public int blueScore = 0;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject enemy;
    private Vector3 playerpos;
    private Vector3 enemypos;
    private Rigidbody playerrb;
    private Rigidbody enemyrb;
    void Start()
    {
        playerpos = player.transform.position;
        enemypos = enemy.transform.position;
        playerrb = player.GetComponent<Rigidbody>();
        enemyrb = enemy.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "RedScore:" + redScore + "  BlueScore:" + blueScore;

    }

    public void AfterScore(GameObject obj)
    {
        if (obj.CompareTag("Finish"))
        {
            redScore++;
            Debug.Log("red");
            playerrb.velocity = Vector3.zero;
            player.transform.position = playerpos;
        }

        if (obj.CompareTag("Player"))
        {
            blueScore++;
            Debug.Log("blue");
            enemyrb.velocity = Vector3.zero;
            enemy.transform.position = enemypos;
        }
        text.text = "RedScore:" + redScore + "  BlueScore:" + blueScore;
    }
}
