using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb; // reference to rigidbody component

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate() // playing around with physics
    {
    	// add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // press d key
        if (Input.GetKey("d")) { // add force to the right
        	rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // press a key
        if (Input.GetKey("a")) { // add force to the left
        	rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
