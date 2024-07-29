using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnSistemi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(DataBase.SpawnPosition == Vector3.zero)
        {
            DataBase.SpawnPosition = transform.position;
        }
        transform.position = DataBase.SpawnPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Restart")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            transform.position = DataBase.SpawnPosition;
        }
    }
}
