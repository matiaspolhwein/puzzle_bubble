using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cañon_pos_instancia : MonoBehaviour
{
    Rigidbody2D rb2d;
    public static Vector3 posicion;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       posicion = rb2d.position;
    }
}
