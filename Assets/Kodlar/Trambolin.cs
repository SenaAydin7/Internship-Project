using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trambolin : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 YeniHiz;
        YeniHiz.x = collision.gameObject.GetComponent<Rigidbody>().velocity.x;
        YeniHiz.y = 10f;
        YeniHiz.z = collision.gameObject.GetComponent<Rigidbody>().velocity.z;

        collision.gameObject.GetComponent<Rigidbody>().velocity = YeniHiz;
    }
}
