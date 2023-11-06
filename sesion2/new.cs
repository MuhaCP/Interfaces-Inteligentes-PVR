using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entrepuntos : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 punto1;
    public Vector3 punto2;
    
    float speed = 5f;
    bool isSilla = false;

    float time = 0f;

    void Start()
    {
        punto1 = new Vector3(Random.Range(-2.5f, 3f), 0, Random.Range(2.5f, 7f));
        punto2 = new Vector3(Random.Range(-2.5f, 3f), 0, Random.Range(2.5f, 7f));
    }

    // Update is called once per frame

    void moveToPunto1()
    {
        transform.position = Vector3.MoveTowards(transform.position, punto1, speed * Time.deltaTime);
    }

    void moveToPunto2()
    {
        transform.position = Vector3.MoveTowards(transform.position, punto2, speed * Time.deltaTime);
    }

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
            moveToPunto1();
        }
        else
        {
            moveToPunto2();
        }
        
    }
}
