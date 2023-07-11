using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clamp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _maxRadius = 3;
    private Vector3 mid = new Vector3(45,0,0); // �G�̂Ƃ��ς���
    void Start()
    {
       
    }

    // Update is called once per frame
    /*
     * ���҂���鋓��
     * 45,0,0����x�N�g������3���������Ȃ��悤�ɂ���
     * �Ⴆ�Ό��_����Ȃ�0,0,0������A�x�N�g����3�Ƃ����Ă��ȒP
     * �������Amid��0�Ƃ��Č��݂�pos���ǂꂮ�炢�����Ă��邩������
     * diff = pos - mid
     * clamp(diff,3)�ŗǂ��킯��
     * 
     */
    void Update()
    {
        var pos = transform.position; // ���ꂪ���ł����A�N�����v���ė}����
        var diff = pos - mid;
        var clamp = Vector3.ClampMagnitude(diff, _maxRadius);
        var result = clamp + mid;
        transform.position = result;
    }
}
