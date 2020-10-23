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

        if (Input.GetKey("d")) {
        	rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a")) {
        	rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
