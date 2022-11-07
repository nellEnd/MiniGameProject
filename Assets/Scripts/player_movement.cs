using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
 
{
    [SerializeField]
    float speed;

    private Rigidbody playerBall;

    [SerializeField]
    private float jumpForce;

    [SerializeField]
    private float jumping;

    private Vector3 jump;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        jump = new Vector3(0f, jumping, 0f);
        playerBall = GetComponent<Rigidbody>();        
    }

        // Update is called once per frame
       void Update()
       {

        
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                playerBall.AddForce(jump * jumpForce, ForceMode.Impulse);
                isGrounded= false;
            }
        

        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(x, 0, z);
       
       }

    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == ("Ground"))
           isGrounded = true;
    }
   
}

