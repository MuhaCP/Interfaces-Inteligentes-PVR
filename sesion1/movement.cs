using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 10;
    public float rotationSpeed = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime, 0, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime);
        // si se pulsa espacio el personaje salta
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0, 2, 0);
        }

    
    }
}
