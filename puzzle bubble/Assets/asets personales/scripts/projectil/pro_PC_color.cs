using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pro_PC_color : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color color = new Color(45,51,235);
        SpriteRenderer spr;
        spr = GetComponent<SpriteRenderer>();
        spr.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
