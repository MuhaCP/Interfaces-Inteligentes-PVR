using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salta : MonoBehaviour
{
    // Start is called before the first frame update
    bool isGrounded = true;
    public float jumpForce = 5;    
    void Start()
    {
        
    }

    void Update()
    {
        if (gameObject.transform.position.y > 0.1f)
        {
            isGrounded = false;
        }
        else
        {
            isGrounded = true;
        }

        if (isGrounded)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }
    }
}
