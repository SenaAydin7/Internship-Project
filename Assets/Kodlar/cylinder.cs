using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinder : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 topKonumu;
        Vector3 silindirKonumu;

        topKonumu = collision.gameObject.transform.position;
        silindirKonumu = transform.position;

        topKonumu = topKonumu - silindirKonumu;

        collision.gameObject.GetComponent<Rigidbody>().velocity = topKonumu * 10;
    }
}
