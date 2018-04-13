using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class RaySelector : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vButtonSelect;
    public GameObject vButtonSpawn;

    public enum SelectableObjects { Engines, ControlEngineCar, WingEngineCar, RearEngineCar, R34, Wheel };
    public SelectableObjects objects;

    public RaycastHit hitInfo;
    LineRenderer rayLine;
    public Material LRmat1, LRmat2;
    public AudioSource rayAudio;

    public Text header, body;

    //DeployStageOnce _deployStageOnce;


    void Start ()
    {
        vButtonSelect = GameObject.Find("VirtualButton_select");
        vButtonSelect.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        vButtonSpawn = GameObject.Find("VirtualButton_spawn");
        vButtonSpawn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        rayAudio = GetComponent<AudioSource>();
        rayLine = GetComponent<LineRenderer>();

        header.text = "";
        header.enabled = true;
        body.text = "";
        body.enabled = true;
    }

    void Update()
    {
        AimLine();

        //SearchObjects();

        SelectedObjects();
    }



    public void OnButtonPressed(VirtualButtonBehaviour vButton)
    {
        if (vButton.gameObject.name == "VirtualButton_select")
        {
            Debug.Log("SELECT BUTTON PRESSED");

            rayLine.material = LRmat2;
            rayLine.SetWidth(1, 1);

            if (Physics.Raycast(transform.position, transform.forward, out hitInfo))
            {
                Debug.Log(hitInfo.transform.name);

                if (hitInfo.collider)
                    rayLine.SetPosition(1, hitInfo.point);
            }

            SearchObjects();
        }
        if (vButton.gameObject.name == "VirtualButton_spawn")
        {
            Debug.Log("SPAWN BUTTON PRESSED");
            //_deployStageOnce.OnInteractiveHitTest(result);
        }
    }



    public void OnButtonReleased(VirtualButtonBehaviour vButton)
    {
        if (vButton.gameObject.name == "VirtualButton_select")
        {
            Debug.Log("Select button RELEASED");

            rayLine.material = LRmat1;
            rayLine.SetWidth(0.2f, 0.2f);
        }
        if (vButton.gameObject.name == "VirtualButton_spawn")
        {
            Debug.Log("Spawn button RELEASED");
            rayLine.enabled = false;
        }
    }



    void AimLine()
    {
        rayLine.SetPosition(0, transform.position);

        Debug.DrawRay(transform.position, transform.forward * 1000, Color.green);

        rayLine.SetPosition(1, transform.forward * 1000);
    }



    void SearchObjects()
    {
        if (hitInfo.transform.name == "R34")
        {
            Debug.Log("R34");
            objects = SelectableObjects.R34;
        }
        if (hitInfo.transform.name == "Engines")
        {
            Debug.Log("Engines");
            objects = SelectableObjects.Engines;
        }
        if (hitInfo.transform.name == "ControlEngineCar")
        {
            Debug.Log("ControlEngineCar");
            objects = SelectableObjects.ControlEngineCar;
        }
        if (hitInfo.transform.name == "WingEngineCar")
        {
            Debug.Log("WingEngineCar");
            objects = SelectableObjects.WingEngineCar;
        }
        if (hitInfo.transform.name == "RearEngineCar")
        {
            Debug.Log("RearEngineCar");
            objects = SelectableObjects.RearEngineCar;
        }
        if (hitInfo.transform.name == "Wheel")
        {
            Debug.Log("Wheel");
            objects = SelectableObjects.Wheel;
        }
    }



    void SelectedObjects()
    {
        switch(objects)
        {
            case SelectableObjects.ControlEngineCar:
                header.text = "ControlControlControlControlControlControlControlControlControl";
                body.text = "ControlControlControlControlControlControlControlControlControlControl";
                Debug.Log("ControlEngineCar");
                SearchObjects();
                break;
            case SelectableObjects.WingEngineCar:
                header.text = "WingWingWingWingWingWingWingWingWingWingWing";
                body.text = "WingWingWingWingWingWingWingWingWingWingWingWing";
                Debug.Log("WingEngineCaar");
                SearchObjects();
                break;
            case SelectableObjects.RearEngineCar:
                header.text = "RearRearRearRearRearRearRearRearRearRearRearRear";
                body.text = "RearRearRearRearRearRearRearRearRearRear";
                Debug.Log("RearEngineCar");
                SearchObjects();
                break;
            case SelectableObjects.Engines:
                header.text = "PropellerPropellerPropellerPropellerPropellerPropellerPropellerPropeller";
                body.text = "PropellerPropellerPropellerPropellerPropellerPropellerPropellerPropellerPropellerPropellerPropeller";
                Debug.Log("Engines");
                SearchObjects();
                break;
            case SelectableObjects.R34:
                header.text = "R34R34R34R34R34R34R34R34R34R34";
                body.text = "R34R34R34R34R34R34R34R34R34R34R34";
                Debug.Log("R34");
                SearchObjects();
                break;
            case SelectableObjects.Wheel:
                header.text = "WheelWheelWheelWheelWheelWheelWheelWheel";
                body.text = "WheelWheelWheelWheelWheelWheelWheelWheelWheelWheel";
                Debug.Log("Wheel");
                SearchObjects();
                break;
            default:
                Debug.Log("default innit");
                break;
        }
    }
}
