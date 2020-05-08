using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string myName;
    public float speed = 1.5f;
    public float panSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am alive and my name is " + myName);
    }

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;
    }
}
