using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataBase
{
    public static int AltinSayisi;
    public static Vector3 SpawnPosition;
    public static void LoadData()
    {
        AltinSayisi = PlayerPrefs.GetInt("AltinSayisi");
        
    }
    public static void SaveData()
    {
        PlayerPrefs.SetInt("AltinSayisi",AltinSayisi);
    }
}
