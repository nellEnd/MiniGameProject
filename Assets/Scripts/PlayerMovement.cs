using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 3f;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private Transform groundCheck = null;

    private Vector3 movement;

    private Rigidbody playerBody;

    bool shouldJump = false;
    private bool grounded = false;

   // private RaycastHit hitInfo;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        movement = new Vector3(x * speed * Time.deltaTime, 0, z * speed * Time.deltaTime);
        transform.Translate(movement);

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            shouldJump = true;
        }

        /*Debug.DrawRay(transform.position, -transform.up * 0.6f, Color.red);

        if (Physics.Raycast(transform.position, -transform.up, out hitInfo, 0.6f, groundMask))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
        */
    }

   /* private void FixedUpdate()
    {
        Vector3 newPosition = transform.position + (movement * speed * Time.fixedDeltaTime);
        playerBody.MovePosition(newPosition);

        if (shouldJump)
        {
            playerBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            shouldJump = false;
        }
    }
   */
}
