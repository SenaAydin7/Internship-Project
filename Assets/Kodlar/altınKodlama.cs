using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class altınKodlama : MonoBehaviour
{
    [SerializeField] Vector3 donmeYonu;
    [SerializeField] TextMeshProUGUI goldTxt;
    // Start is called before the first frame update
    void Start()
    {
        goldTxt.text = $"Gold = {DataBase.AltinSayisi}";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(donmeYonu);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
            DataBase.AltinSayisi++;
            goldTxt.text = $"Gold = {DataBase.AltinSayisi}";
            Debug.Log(DataBase.AltinSayisi);
        }
    }
}
