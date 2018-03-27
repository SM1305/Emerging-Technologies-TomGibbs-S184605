using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vButtonForward : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vButtonForwardObj;
    public GameObject ship;
    public float speed;
    private bool moving;

    void Start()
    {
        vButtonForwardObj = GameObject.Find("vButton_forward");
        vButtonForwardObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        moving = false;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Virtual Button FORWARD pressed!!!");
        moving = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Virtual Button FORWARD released!");
        moving = false;
    }


    void Update()
    {
        if (moving)
        {
            ship.transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }
    }
}
