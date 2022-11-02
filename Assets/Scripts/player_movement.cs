using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
 
{
    [SerializeField]
    float speed;

    private Vector3 movement;
    private Rigidbody playerBall;

    private Vector3 jump;
    public float jumpForce = 2.0f;

    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        playerBall = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
        // Update is called once per frame
       void Update()
       {
         Vector3 playerInput;

         playerInput.x = Input.GetAxis("Horizontal");
         playerInput.z = Input.GetAxis("Vertical");

         Vector3 movement = new Vector3(playerInput.x * speed * Time.deltaTime, 0.0f, playerInput.z * speed * Time.deltaTime);
         transform.Translate(movement);

          if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
          {
           playerBall.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
          }

       }
}

