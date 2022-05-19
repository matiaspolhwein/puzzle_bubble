using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon_atributos : MonoBehaviour
{
    Rigidbody2D rb2d;
    public static Vector3 posicion;
    public static float rotacion = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rotacion = rb2d.rotation;
        posicion = rb2d.position;
    }


}
