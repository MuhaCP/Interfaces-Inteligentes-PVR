using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escucha : MonoBehaviour
{
    public evento bed;
    bool move = false;
    bool isGrounded = true;
    float jumpForce = 50;
    // Start is called before the first frame update
    void Start()
    {
        bed.newEvento += moveT;      
    }

    void moveT ()
    {
        move = true;
    }

    void moveSideToSide(float time)
    {
        if (gameObject.tag == "bed" && move)
        {
            if ((time%2) == 0)
            {
                gameObject.transform.Translate(Vector3.right * Time.deltaTime);
            }
            else
            {
                gameObject.transform.Translate(Vector3.left * Time.deltaTime);
            }
        }
    }

    void jumpChair()
    {
        if(gameObject.tag == "chair" && move)
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

    void Update()
    {
        float time = 0f;
        time += Time.deltaTime;
        moveSideToSide(time);
        jumpChair();
    }  
}
