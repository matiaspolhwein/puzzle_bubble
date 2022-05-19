using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pro_movimiento : MonoBehaviour
{

    float x = 130f;
    float y = 200f;
    float r;
    
    GameObject proyectil;
    Vector2 positivo;
    Vector2 negativo;
    Vector2 neutro;

    int vel = 75;
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        proyectil = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        r = Cañon_atributos.rotacion;



        positivo = new Vector2(x, y);
        negativo = new Vector2(-x, y);
        neutro = new Vector2(0,y);
        if (r>0) {
            rb2d.AddForce(positivo * Time.deltaTime);
        }
        else if (r<0){
            rb2d.AddForce(negativo *Time.deltaTime);
        }
        else if (r == 0) {
            rb2d.AddForce(neutro * Time.deltaTime);
        }
        if (rb2d.position.y > 5)
        {
            Object.Destroy(gameObject);
        }
        else if (rb2d.position.y < -5)
        {
            Object.Destroy(gameObject);
        }
        else if (rb2d.position.x > 3)
        {
            Object.Destroy(gameObject);
        }
        else if (rb2d.position.x < -3) {
            Object.Destroy(gameObject);
        }
        }
    
    }
    

