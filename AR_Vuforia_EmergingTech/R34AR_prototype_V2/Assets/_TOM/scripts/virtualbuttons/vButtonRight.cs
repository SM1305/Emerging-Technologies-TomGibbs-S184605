using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vButtonRight : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vButtonRightObj;
    public GameObject ship;
    private float rotateSpeed = 40f;
    private bool turningR;

    void Start()
    {
        vButtonRightObj = GameObject.Find("vButton_right");
        vButtonRightObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        turningR = false;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Virtual Button RIGHT pressed!!!");
        turningR = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Virtual Button RIGHT released!");
        turningR = false;
    }


    void Update()
    {
        if (turningR)
        {
            ship.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
    }
}
