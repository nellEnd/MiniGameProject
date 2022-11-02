using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

  public class collidingScript : MonoBehaviour
{
    public GameObject goalText;
    public GameObject playerTrigger;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
           goalText.SetActive(true);       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerTrigger)
            playerTrigger.transform.parent = transform;
    }
}
