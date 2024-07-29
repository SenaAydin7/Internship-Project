using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]GameObject FollowObj;
    [SerializeField] Vector3 OffSet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = FollowObj.transform.position + OffSet;
    }
}
