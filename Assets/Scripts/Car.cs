using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    float Speed = 0;
    Vector2 StartPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 EndPos = Input.mousePosition;
            float SwipeLength = EndPos.x - StartPos.x;
            Speed = SwipeLength / 1000.0f;
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(Speed, 0, 0);
        //transform.position += new Vector3(Speed, 0, 0);
        Speed *= 0.98f;
        //Speed = Speed * 0.98f;
    }
}
