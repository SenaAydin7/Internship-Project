using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataBase.LoadData();
    }

    // Update is called once per frame
    public void ClickPlayButton()
    {
        SceneManager.LoadScene("Level1");
    }
}
