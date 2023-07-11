using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorPosition : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cursor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        mouse.z = 48;
        Vector3 target = Camera.main.ScreenToWorldPoint(mouse);
        cursor.transform.position = target;
    }
}
