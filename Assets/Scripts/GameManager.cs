using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  UIManager uiManager;
    public float tiempo =0f;
    public float TRestante = 60f;
    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
      if(uiManager.JuegoEmpezado){
  TRestante-= Time.deltaTime;
    TRestante = Mathf.Max(TRestante, 0f);
      }
     
    }
}
