using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class cañon : MonoBehaviour
{
    Rigidbody2D rb2d;
    float rotacion = 1;
    void Start()
    {
      
            rb2d = GetComponent<Rigidbody2D>();

    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.MoveRotation(rb2d.rotation + rotacion*Time.deltaTime);
            Thread.Sleep(10);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb2d.MoveRotation(rb2d.rotation - rotacion*Time.deltaTime);
            Thread.Sleep(10);

        }
    }
}
