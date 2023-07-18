using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    /*
     * ���߂��鋓��
     * ����������̋������ꂽ��X�R�A
     * transform.position.magnitude�ł�����
     * ���ꂪ���l��������A�A�E�g
     * tag�ς��Ăǂ����������悤�ɂ����ق�����������
     * 
     * ������������
     *�@���̃X�N���v�g���Q�x�C�ɐݒu���������ŋ�������������
     *�@�X�R�A�͕ʃX�N���v�g�ŁA������A�ǂ������̃I�u�W�F�ɂ����A�͈͊O����p�X�N���v�g��ݒu����ׂ����H
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
