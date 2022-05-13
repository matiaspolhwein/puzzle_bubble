using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pro_movimiento : MonoBehaviour
{

    float x = 0.036f;
    float y = 0.02f;
    float r;

    Vector2 sipar;
    Vector2 nopar;
    float x_par;
    float y_par;
 
    int vel = 5;
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
            
    }

    // Update is called once per frame
    void Update()
    {
        r = Cañon_atributos.rotacion;

      
        x_par = r/2;
        y_par = r/2;

        sipar = new Vector2(x_par, y_par);
        nopar = new Vector2(sipar.x / 2 + sipar.x, sipar.y / 2 + sipar.y);

        rb2d.MovePosition(sipar*vel*Time.deltaTime);
        Debug.Log(x_par);

      //  rb2d.position = rb2d.position + nopar * vel * Time.deltaTime;
        {
        }
    }
}
