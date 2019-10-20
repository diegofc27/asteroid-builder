using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoInicial : MonoBehaviour
{

    public GameObject puntoIni;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = puntoIni.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
