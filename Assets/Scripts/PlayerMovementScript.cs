using UnityEngine;
using System.Collections;

public class PlayerMovementScript : EngineBase
{
    private Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start()
    {
        // Get OurRigidbodyComponent once at the start of the game and store a reference to it
        // This means that we don't need to call GetComponent more than once! This makes our game faster. (GetComponent is SLOW)
        ourRigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f)
        {
            Vector2 ForceToAdd=Vector2.right*HorizontalInput*acceleration*Time.deltaTime;
            ourRigidbody.AddForce(ForceToAdd);
            //print(HorizontalInput);
        }
    }
}
