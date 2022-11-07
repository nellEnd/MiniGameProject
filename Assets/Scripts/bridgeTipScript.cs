using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTipScript : MonoBehaviour
{
    public GameObject tipText;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        { 
            tipText.SetActive(true);
            Destroy(tipText, 2);
        }

    }
}
