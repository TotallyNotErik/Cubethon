using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce* Time.fixedDeltaTime);

        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce * Time.fixedDeltaTime,0,0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce * Time.fixedDeltaTime,0,0, ForceMode.VelocityChange);
        }

        if (transform.position.y < -1)
            FindObjectOfType<GameManager>().EndGame();
    }
}
