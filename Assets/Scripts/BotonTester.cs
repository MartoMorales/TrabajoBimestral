using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BotonTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => {
            Debug.Log("CLICK DETECTADO");
            FindObjectOfType<UIManager>().EmpezarJuego();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
