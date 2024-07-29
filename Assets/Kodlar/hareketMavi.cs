using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketMavi : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody body;
    public float speed = 30;
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            body.AddForce(0, 0, speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.K))
        {
            body.AddForce(0, 0, -speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.J))
        {
            body.AddForce(-speed * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.L))
        {
            body.AddForce(speed * Time.deltaTime, 0, 0);

        }
    }
}
