using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class PlayerMovement : MonoBehaviour
{
    FirstPersonController fpsController;
    UIManager uiManager;
    public GameObject[] pickables;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        pickables = GameObject.FindGameObjectsWithTag("Pickable");
        player = GameObject.FindGameObjectWithTag("Player");
        fpsController = player.GetComponent<FirstPersonController>();
         uiManager = FindObjectOfType<UIManager>();
        fpsController.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (uiManager.JuegoEmpezado && !fpsController.enabled)
        {
            fpsController.enabled = true;
        }
        if(!uiManager.JuegoEmpezado && fpsController.enabled)
        {
            fpsController.enabled = false;
        }
    }
     void OnTriggerEnter(Collider chocado)
    {
        for(int i =0; i<pickables.Length;i++)
        {
            if(pickables[i] == chocado.gameObject)
            {
                Destroy(chocado.gameObject);
                Debug.Log("El objeto ha sido agarrado");
                uiManager.Puntaje += 1;
                uiManager.UpdateScore();
                Debug.Log(uiManager.Puntaje);
            }
    }    
}
}
