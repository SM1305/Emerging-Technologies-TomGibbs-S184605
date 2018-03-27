using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vButtonLeft : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vButtonLeftObj;
    public GameObject ship;
    public float rotateSpeed = 40f;
    private bool turningL;

    void Start()
    {
        vButtonLeftObj = GameObject.Find("vButton_left");
        vButtonLeftObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        turningL = false;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Virtual Button LEFT pressed!!!");
        turningL = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Virtual Button LEFT released!");
        turningL = false;
    }

    void Update()
    {
        if (turningL)
        {
            ship.transform.Rotate(-Vector3.up * rotateSpeed * Time.deltaTime);
        }
    }
}
