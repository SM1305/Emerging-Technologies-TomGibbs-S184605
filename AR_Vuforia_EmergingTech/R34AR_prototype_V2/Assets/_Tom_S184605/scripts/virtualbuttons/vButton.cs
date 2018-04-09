using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vButton : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vButtonObj;

	void Start ()
    {
        vButtonObj = GameObject.Find("vButton");
        vButtonObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
	
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        Debug.Log("Virtual Button PRESSED!!!");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Virtual Button is RELEASED!!!");
    }


	void Update ()
    {
		
	}
}
