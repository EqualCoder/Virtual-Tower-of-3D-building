using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOutside : MonoBehaviour
{
    float inputX, inputZ;
    public int speed = 10;
    public int speed2 = 16;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
        if (inputX != 0)
        {
            rotate();
        }
        if (inputZ != 0)
        {
            Move();
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
    }
    public void Move()
    {
        transform.position += transform.forward * inputZ * Time.deltaTime * speed;
        
    }
    public void rotate()
    {
        transform.Rotate(new Vector3(0f, inputX * Time.deltaTime * speed2, 0f));
    }
   
}
