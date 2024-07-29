using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLevel2 : MonoBehaviour
{
    void Start()
    {
        DataBase.LoadData();
    }

    // Update is called once per frame
    public void ClickPlayButton()
    {
        SceneManager.LoadScene("Level2");
    }
}
