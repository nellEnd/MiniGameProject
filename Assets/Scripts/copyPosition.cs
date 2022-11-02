using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copyPosition : MonoBehaviour
{
    [SerializeField]
    Transform cameraRig;

    // Update is called once per frame
    void Update()
    {
        transform.position = cameraRig.position;
        transform.LookAt(cameraRig);
    }
}
