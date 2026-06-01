using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float tiempo =0f;
    public float TRestante = 60f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      TRestante-= Time.deltaTime;
    TRestante = Mathf.Max(TRestante, 0f);
    }
}
