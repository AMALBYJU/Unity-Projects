using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 1f;

    // We made this as FixedUpdate cause we want to 
    // mess with Unity physics system.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 
        
        if(Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y <= -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
