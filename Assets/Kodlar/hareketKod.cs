using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketKod : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody body;
    [SerializeField] GameObject cameraObj;
    public float speed = 30;
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 moveTo = cameraObj.transform.forward;
            moveTo.y = 0;
            moveTo = moveTo.normalized;
            body.AddForce(moveTo * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 moveTo = -cameraObj.transform.forward;
            moveTo.y = 0;
            moveTo = moveTo.normalized;
            body.AddForce(moveTo * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 moveTo = -cameraObj.transform.right;
            moveTo.y = 0;
            moveTo = moveTo.normalized;
            body.AddForce(moveTo * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 moveTo = cameraObj.transform.right;
            moveTo.y = 0;
            moveTo = moveTo.normalized;
            body.AddForce(moveTo * speed * Time.deltaTime);

        }
    }
}
