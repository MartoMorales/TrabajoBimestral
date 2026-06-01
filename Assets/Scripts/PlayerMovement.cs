using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject[] pickables;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        pickables = GameObject.FindGameObjectsWithTag("Pickable");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
 
    }
     void OnTriggerEnter(Collider chocado)
    {
        for(int i =0; i<pickables.Length;i++)
        {
            if(pickables[i] == chocado.gameObject)
            {
                pickables[i].transform.SetParent(player.transform);
                Debug.Log("El objeto ha sido agarrado");
            }
    }    
}
}
