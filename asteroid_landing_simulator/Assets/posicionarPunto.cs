using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;

public class posicionarPunto : MonoBehaviour
{


    public GameObject puntero;
    public GameObject puntero2;

    // data
    public int recclass1;
    public double mass_;
    public double reclat_;
    public double reclong_;

    // Use this for initialization
    void Start()
    {
        float lat = 29.594954f;
        float lon = -110.137905f;
        posicionar(lat, lon);

        // data
        System.Random rm = new System.Random();
        string[][] nueva = geMatrix();
        int indice = rm.Next(1, nueva.Count());
        GetVariables(nueva[indice][1], nueva[indice][2], nueva[indice][4], nueva[indice][5]);
        posicionar((float)this.reclat_, (float)this.reclong_);
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
        this.puntero.transform.Rotate(new Vector3(0, rotaciónY, rotaciónZ));
        this.puntero2.transform.Rotate(new Vector3(0, rotaciónY, rotaciónZ));
    }
    public string[][] geMatrix()
    {
        string filePath = @"C:\Users\kevin\3D Objects\Meteorite_Landings_Preprocessed.csv";
        StreamReader sr = new StreamReader(filePath);
        var lines = new List<string[]>();
        int Row = 0;
        while (!sr.EndOfStream)
        {
            string[] Line = sr.ReadLine().Split(',');
            lines.Add(Line);
            Row++;
        }

        return lines.ToArray();
    }

    public void GetVariables(string type, string mass, string reglat, string reclong)
    {

        this.recclass1 = Convert.ToInt32(type);
        this.mass_ = Convert.ToDouble(mass);
        this.reclat_ = Convert.ToDouble(reglat);
        this.reclong_ = Convert.ToDouble(reclong);

        //posicionar((float)this.reclat_, (float)this.reclong_);

        if (recclass1 <= 5)
        {
            //tipo.transform.position = new Vector3(11, 11, 11);

        }
        else
        {
            // tipo.transform.position = new Vector3(11, 11, 11);

        }

    }
}
