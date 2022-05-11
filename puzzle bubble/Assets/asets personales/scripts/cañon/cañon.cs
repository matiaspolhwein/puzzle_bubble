using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class cañon : MonoBehaviour
{

    //clase encargada del movimiento posicion y atributos basicos del cañon
    Vector3 pos_inicial = new Vector3(0, -3, 0);
    Rigidbody2D rb2d;
    float rotacion = 150;
    void Start()
    {
      
            rb2d = GetComponent<Rigidbody2D>();

    }
    private void Update()
    { 
        if (Input.GetKey(KeyCode.D) && rb2d.rotation > -75)
        {
            rb2d.MoveRotation(rb2d.rotation - rotacion * Time.deltaTime);
            Thread.Sleep(10);
        }
        else if (Input.GetKey(KeyCode.A) && rb2d.rotation < 75)
        {
            rb2d.MoveRotation(rb2d.rotation + rotacion * Time.deltaTime);
            Thread.Sleep(10);

        }
        else if (rb2d.rotation < -75) {
            rb2d.rotation = -75;
        }
        else if (rb2d.rotation > 75)
        {
            rb2d.rotation = 75;
        }
        rb2d.position = pos_inicial;
    }
}
