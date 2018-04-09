using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextToCam : MonoBehaviour
{
    public Camera ARcam;

    void Start()
    {

    }

    void Update()
    {
        Vector3 vec = ARcam.transform.position - transform.position;

        vec.x = vec.z = 0.0f;

        transform.LookAt(ARcam.transform.position - vec);

        transform.rotation = (ARcam.transform.rotation);
    }
}


