using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopKontrolu : MonoBehaviour
{
    public float ziplamaKuvveti = 15f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up*ziplamaKuvveti;
        }
    }
}
