using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField]
    private countingCoinsScript scoreCounting;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {         
            scoreCounting.IncreasePoint();                 
            Destroy(gameObject);
        }
    }
}
