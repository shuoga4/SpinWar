using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OutofRange : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float range = 40;
    [SerializeField] Score score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        var mag = pos.magnitude;
        if (mag >= range)
        {
            score.AfterScore(gameObject);
        }
    }
}
