using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerFocus : MonoBehaviour
{
    // Start is called before the first frame update
    /*
     * ���҂���鋓��
     * �J�[�\���̓������󂯂ăX�e�[�W�̏�𓮂��A�R�}���������Ă��������Ƃ��ăt�H�[�J�X���󂯂�
     * �܂�ő�������悤�ɋ���������
     * cursor - mid * �萔
     * ��L.y = �萔
     * �ŏI��肶��ˁH
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
        var fromWP = (lever.transform.position - mid) * amplificatenum; // �G�̂Ƃ��ς���
        fromWP.y = 1;
        transform.position = fromWP;
    }
}
