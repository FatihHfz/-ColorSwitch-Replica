using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CemberKontrolu : MonoBehaviour
{
    public bool solaDon = true;
    public float donmeHizi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(solaDon)
        {
            transform.Rotate(0f,0f,donmeHizi*Time.deltaTime);
        }
        else
        {
            transform.Rotate(0f,0f,-donmeHizi*Time.deltaTime);
        }

    }
}
