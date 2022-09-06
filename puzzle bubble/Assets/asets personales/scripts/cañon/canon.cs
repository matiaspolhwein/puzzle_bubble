using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon : MonoBehaviour
{
    Rigidbody2D rb2d;
   
    float rotacion;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() { 


    Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    rotacion = mousepos.x;
        Vector2 posicion = new Vector2( 0.027f*-rotacion, 0.157f*-rotacion);
        rb2d.rotation = -rotacion * 10;
        
        if (rb2d.rotation > 75)
        {
            rb2d.rotation = 75;
        }
        else if (rb2d.rotation < -75) {
            rb2d.rotation = -75;
        }
        if (posicion.x > 1.89f)
        {
            posicion.x = 1.89f;
        }
        else if (posicion.y < 1.1f)
        {
            posicion.y = 1.1f;
        }
        if (posicion.x < 0.027f)
        {
            posicion.x = 0.027f;
        }
        else if (posicion.y > 0.157f)
        {
            posicion.y = 0.157f;
        }
        rb2d.position = -posicion;
    }
}
