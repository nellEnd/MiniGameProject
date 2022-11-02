using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGameAtCollision : MonoBehaviour
{
    [SerializeField]
    string playerTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == playerTag)

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
