using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public int Speed;
    public int minSpeed;
    public int maxSpeed;
    public float horizontalSpeed;
    float h;

    // Start is called before the first frame update
    void Start()
    {
        Speed = minSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")) //Input on key w
            rb.AddRelativeForce(0, 0, Speed);

        if (Input.GetKey("a")) //Input on key a
            rb.AddRelativeForce(-Speed, 0, 0);

        if (Input.GetKey("s")) //Input on key s
            rb.AddRelativeForce(0, 0, -Speed);

        if (Input.GetKey("d")) //Input on key d
            rb.AddRelativeForce(Speed, 0, 0);

        if (rb.velocity.magnitude > maxSpeed)  //if velocity is past speed stop accelerating
        {
            Speed = 0;
        }
        else
        {
            Speed = minSpeed;
        }


        h = horizontalSpeed * Input.GetAxis("Mouse X");  //Mouse movement
        transform.Rotate(0, h, 0); //turn player
    }
}
