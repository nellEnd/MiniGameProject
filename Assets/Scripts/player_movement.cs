using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
 
{
    [SerializeField]
    float speed;

    private Vector3 movement;
    private Rigidbody playerBall;
    
    public float jumpForce = 2f;

    // Start is called before the first frame update
    void Start()
    {
        playerBall = GetComponent<Rigidbody>();        
    }

        // Update is called once per frame
       void Update()
       {         

         float x = Input.GetAxis("Horizontal");
         float z = Input.GetAxis("Vertical");

         Vector3 movement = new Vector3(x * speed * Time.deltaTime, 0.0f, z * speed * Time.deltaTime);
         transform.Translate(movement);
        

          if (Input.GetKeyDown(KeyCode.Space))
          {
            playerBall.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
          }

       }
}

