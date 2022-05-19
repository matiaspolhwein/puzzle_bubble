using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pro_instanciar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject proyectil;
    Vector3 posicion = cañon_pos_instancia.posicion;
    void Start()
    {
        proyectil = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(proyectil, posicion, Quaternion.identity);
            
        }
        Debug.Log(posicion.y);
    }
}
