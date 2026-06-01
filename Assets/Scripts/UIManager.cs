using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    GameManager GameManager;
    public TextMeshProUGUI TextoPuntaje;
    public TextMeshProUGUI Temporizador;
    public int Puntaje;
    
 
    // Start is called before the first frame update
    void Start()
    {
        Puntaje = 0;
        GameManager = FindObjectOfType<GameManager>();
           Debug.Log("GameManager: " + GameManager);
    Debug.Log("Temporizador: " + Temporizador);
    Debug.Log("TextoPuntaje: " + TextoPuntaje);
    }

    // Update is called once per frame
    void Update(){
        UpdateTimer();
    }
    public void UpdateScore()
    {
        TextoPuntaje.text = "Puntaje: " + Puntaje;
    }

    public void UpdateTimer(){
        Temporizador.text = "Tiempo restante: " + Mathf.RoundToInt(GameManager.TRestante);
    }
}

