using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeybladeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    /*
     * ���߂��鋓��
     * �Ɗy�̓���������
     * ���܂̓����Ƃ�
     * �����x�ő��삷��
     * ���o�[��|��������ƁA�ŏ��͒x�����ǂ��񂾂񑁂��Ȃ�悤�Ȏd�l
     * �͂�����������X�^���X�̂ق����Avelocity���ǂ������B
     * 
     *�@�Ԃ������Ƃ������͕ʃX�N���v�g��
     * 
     * ����Ă銴�̎���
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
