using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        DataBase.SpawnPosition = transform.position;
    }
}
