using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desplazar : MonoBehaviour
{
    public GameObject puntoB;
    public float speed;
    //public Transform target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, puntoB.transform.position, step);
    }

    void desplazamiento()
    {


    }
}
