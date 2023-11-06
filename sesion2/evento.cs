using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evento : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void NuevoEvento();
    public event NuevoEvento newEvento;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "bedwithperson" && newEvento != null)
        {
            newEvento();
        }
    }
}

