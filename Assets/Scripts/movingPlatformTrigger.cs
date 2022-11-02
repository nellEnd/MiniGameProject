using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatformTrigger : MonoBehaviour
{
    public GameObject playerBall;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerBall)
        {
            playerBall.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == playerBall)
        {
            playerBall.transform.parent = null;
        }
    }

}
