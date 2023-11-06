using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebetwin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject silla;
    public GameObject mesa;
    float speed = 5f;
    bool isSilla = false;
    float time = 0f;
    void Start()
    {
        
    }

    void moveToSilla()
    {
        transform.position = Vector3.MoveTowards(transform.position, silla.transform.position, speed * Time.deltaTime);
    }

    void moveToMesa()
    {
        transform.position = Vector3.MoveTowards(transform.position, mesa.transform.position, speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 2f)
        {
            isSilla =  !isSilla;
            time = 0;
        }
        if (isSilla)
        {
            moveToMesa();
        }
        else
        {
            moveToSilla();
        }
    }
}
