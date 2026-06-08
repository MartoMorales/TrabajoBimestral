using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public bool JuegoEmpezado;
    GameManager gameManager;
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
        JuegoEmpezado = false;
        gameManager = FindObjectOfType<GameManager>();
        Debug.Log("GameManager: " + gameManager);
        Debug.Log("Temporizador: " + Temporizador);
        Debug.Log("TextoPuntaje: " + TextoPuntaje);
       Panel_Empezar.GetComponentInChildren<UnityEngine.UI.Button>().onClick.AddListener(EmpezarJuego);
    }

    // Update is called once per frame
   void Update()
{
    if (JuegoEmpezado)
    {
        UpdateScore();
        UpdateTimer();

        if (Puntaje == 3)
        {
            GanarJuego();
        }

        if (gameManager.TRestante == 0)
        {
            PerderJuego();
        }
    }
}
    public void UpdateScore()
    {
        TextoPuntaje.text = "Puntaje: " + Puntaje;
    }

    public void UpdateTimer(){
        Temporizador.text = "Tiempo restante: " + Mathf.RoundToInt(gameManager.TRestante);
    }
    public void EmpezarJuego(){
  
        Panel_Empezar.SetActive(false);
        Panel_Juego.SetActive(true);
        JuegoEmpezado = true;

    }
    public void PerderJuego(){
        Panel_Juego.SetActive(false);
        Panel_Perder.SetActive(true);
        JuegoEmpezado = false;
        Cursor.lockState = CursorLockMode.None; 
        Cursor.visible = true;

    }
    public void GanarJuego(){
        Panel_Juego.SetActive(false);
        JuegoEmpezado = false;
    }
    public void ReiniciarJuego(){
        Panel_Perder.SetActive(false);
        Panel_Juego.SetActive(true);
        Puntaje = 0;
        JuegoEmpezado = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

