using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    GameManager GameManager;
    public TextMeshProUGUI TextoPuntaje;
    public GameObject Panel_Empezar;
    public GameObject Panel_Juego;
    public GameObject Panel_Perder;
    public TextMeshProUGUI Temporizador;
    public int Puntaje;
    
 
    // Start is called before the first frame update
    void Start()
    {
        Panel_Empezar.SetActive(true);
        Panel_Juego.SetActive(false);
        Panel_Perder.SetActive(false);
        Puntaje = 0;
        GameManager = FindObjectOfType<GameManager>();
           Debug.Log("GameManager: " + GameManager);
    Debug.Log("Temporizador: " + Temporizador);
    Debug.Log("TextoPuntaje: " + TextoPuntaje);
    }

    // Update is called once per frame
    void Update(){
        UpdateTimer();

if(Puntaje == 3)
{
    
}
        if(GameManager.TRestante == 0)
        {
            PerderJuego();
        }
    }
    public void UpdateScore()
    {
        TextoPuntaje.text = "Puntaje: " + Puntaje;
    }

    public void UpdateTimer(){
        Temporizador.text = "Tiempo restante: " + Mathf.RoundToInt(GameManager.TRestante);
    }
    public void EmpezarJuego(){
        Panel_Empezar.SetActive(false);
        Panel_Juego.SetActive(true);
    }
    public void PerderJuego(){
        Panel_Juego.SetActive(false);
        Panel_Perder.SetActive(true);

    }
    public void GanarJuego(){
        
    }
}

