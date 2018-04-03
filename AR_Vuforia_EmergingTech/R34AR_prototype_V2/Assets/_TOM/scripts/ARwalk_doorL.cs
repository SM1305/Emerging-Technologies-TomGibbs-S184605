using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARwalk_doorL : MonoBehaviour
{
    private float currentAngleY = 0;
    private float desiredAngleY = 0f;
    
    private float currentAngleZ = 0f;
    private float desiredAngleZ = 270f;
    
    private float currentAngleX = 0f;
    private float desiredAngleX = 0f;
    
    
    void Start()
    {
    
    }
    
    
    
    void Update()
    {
        currentAngleY = Mathf.LerpAngle(currentAngleY, desiredAngleY, Time.deltaTime * 3f);
        //currentAngleZ = Mathf.LerpAngle(currentAngleZ, desiredAngleZ, Time.deltaTime * 3f);
        transform.localEulerAngles = new Vector3(desiredAngleX, currentAngleY, desiredAngleZ);
    }
    
    void OpenDoor()
    {
        desiredAngleY = 85f;
        desiredAngleZ = 283f;
        desiredAngleX = -11f;
    }
    
    void CloseDoor()
    {
        desiredAngleY = 0f;
        desiredAngleZ = 270f;
        desiredAngleX = 0f;
    }
    
    void OnTriggerEnter(Collider other)
    {
        OpenDoor();
        GetComponent<AudioSource>().Play();
    }
    
    void OnTriggerExit(Collider other)
    {
        CloseDoor();
        GetComponent<AudioSource>().Play();
    }
}