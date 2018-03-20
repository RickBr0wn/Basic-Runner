using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sidewaysForce = 500f;

	// Update is called once per frame
    // Use FixedUpdate when using physics
	void FixedUpdate () {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce*Time.deltaTime); // x, y, z

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -3f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
