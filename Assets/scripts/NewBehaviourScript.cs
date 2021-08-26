using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float ForwardForce=2000f;
    public float LateralForce=25f;
    void Start()
    {
        Debug.Log("Hello World");
        rb.useGravity = true;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            rb.AddForce(0,0,ForwardForce*Time.deltaTime);
   
        //rb.AddForce(0,0,ForwardForce*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(LateralForce*Time.deltaTime ,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-LateralForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(0,0,-ForwardForce*Time.deltaTime);
        }
        if(rb.position.y<-2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
