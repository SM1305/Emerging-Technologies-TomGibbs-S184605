using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vButtonSelect : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbSelect;

 // Use this for initialization
 void Start ()
 {
        vbSelect = GameObject.Find("LacieBtn");
        vbSelect.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
 }
 
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
    }
}﻿