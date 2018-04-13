using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;
using Leap;

public class FingerRaySelector : MonoBehaviour
{
    public GameObject pointer;

    public RaycastHit rayHit;
    public bool ispointing;
    LineRenderer rayLine;

    public TextMesh textOut;

    void Start()
    {
        ispointing = false;
        rayLine = GetComponent<LineRenderer>();

        textOut.text = "Point at an object.";
    }

    void Update()
    {
        if (ispointing)
        {
            Detect();
        }        
        
        if (!ispointing)
        {
            rayLine.enabled = false;
        }
    }

    public void point()
    {
        Debug.Log("is pointing");
        ispointing = true;
    }

    public void unpoint()
    {
        Debug.Log("not pointing");
        ispointing = false;
    }

    void Detect()
    {
        rayLine.enabled = true;

        rayLine.SetPosition(0, pointer.transform.position);

        rayLine.SetWidth(0.2f, 0.2f);

        Debug.DrawRay(pointer.transform.position, pointer.transform.forward * 1000, Color.green);

        rayLine.SetPosition(1, pointer.transform.forward * 1000);

        if (Physics.Raycast(pointer.transform.position, pointer.transform.forward, out rayHit))
        {
            Debug.Log(rayHit.transform.name);

                if (rayHit.transform.name == "Cube_Top" || rayHit.transform.name == "Cube_Low");
                {
                    Debug.Log("Cube");
                    textOut.text = "Cube";
                }
                if (rayHit.transform.name == "Capsule_Top" || rayHit.transform.name == "Capsule_Low")
                {
                    Debug.Log("Capsule");
                    textOut.text = "Capsule";
                }
                if (rayHit.transform.name == "Sphere_Top" || rayHit.transform.name == "Sphere_Low")
                {
                    Debug.Log("Sphere");
                    textOut.text = "Sphere";
            }
        }
    }
}