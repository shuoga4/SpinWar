using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    /*
     * ���߂��鋓��
     * �Ԃ������Ƃ��ɗ��҂��΂��悤�ȋ���
     * addforce��impulse�����肪������
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

    private void OnTriggerEnter(Collider other)
    {
        //other�Ƃ̈ʒu�̍��̎擾�A������t������impulse�ŕ��o����H
        //������΂����炱�̃X�N���v�g�͂ǂ��炩�̂݃A�^�b�`����
        Debug.Log("pass01");
        var diff = transform.position - other.transform.position;
        var amp = diff * explode;
        var oppo = amp * -1;
        if (other.CompareTag("Player"))
        {
            GetComponent<Rigidbody>().AddForce(amp, ForceMode.Impulse);
            other.GetComponent<Rigidbody>().AddForce(oppo, ForceMode.Impulse);
            Debug.Log("pass02");
        }
        /*
         * �p�X���Ȃ��B�Ɗy���u�����_�[����C���|�[�g�������ƁA���̃��b�V�����ۂ̂��̂ɑ΂��Ďl�p�œ͂����̂ŁASA�R�����\�𗘗p����
         * �q�b�g�{�b�N�X���m�F�����Ƃ���A�ǂ����Ԉ���Ă����炵���A���̂��ƃv���C���[��S���̃I�u�W�F�N�g�ɂ�����A�Ƃ������g���K�[���������Ă���̂����킩��Ȃ�
         * �Ƃ肠�����g���K�[���������Ă��邩���悤�A����ς肾�߂������B�����Ƃ��ẮA���b�V�����e�I�u�W�F�N�g�ɂȂ����߃g���K�[�X�N���v�g�����܂������Ă��Ȃ��\������
         * ���b�V���̈ʒu�����G�A�g���K�[�̔��������̓R�����\���K�{�Ȃ̂ɐe�ɂȂ��A�q�ɂ��Ă��Ӗ��Ȃ����Ϻ�
         * �e�Ƀg���K�[���Ă������������b�V���Ȃ�����S�������Ȃ������B
         * �R���_�\������Ȃ��Փ˕��@���l���邩�A���b�V���̐e�I�u�W�F�N�g�̂��܂��\������u�����_�[�ƂƂ��ɍl���邩
         * �������̓v���r���_�[�����ă��j�e�B����E�o���Ȃ���
         * 
         * 
         */
    }
}
