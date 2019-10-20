using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionarPuntoAtmosfera : MonoBehaviour
{


    public GameObject punteroIni;
    public GameObject meteorito;
    //public GameObject atmosefera;

    // Use this for initialization
    void Start()
    {
        float lat = -41.828642f;
        float lon = -67.226674f;
        posicionar(lat, lon);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void posicionar(float latitud, float longitud)
    {
        //Reseteamos la toración
        transform.rotation = Quaternion.identity;

        float rotaciónZ = 0f;
        float rotaciónY = 0f;

        //acomodamos la latitud
        if (latitud >= 0 && latitud <= 90)
        {
            rotaciónZ = latitud;
        }
        else if (latitud < 0 && latitud >= -90)
        {
            rotaciónZ = 360 + latitud;
        }

        //acomodar longitud
        if (longitud >= 0 && longitud <= 180)
        {
            rotaciónY = longitud * -1;
        }
        else if (longitud < 0 && longitud >= -180)
        {
            rotaciónY = (360 + longitud) * -1;
        }

        //rotamos el puntero
        this.punteroIni.transform.Rotate(new Vector3(0, rotaciónY, rotaciónZ));

        //meteorito.transform.position = punteroIni.transform.position;
    }
}
