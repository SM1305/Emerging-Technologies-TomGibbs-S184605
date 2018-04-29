using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class RaySelector : MonoBehaviour, IVirtualButtonEventHandler //inherits from IVirtualButtonEventHandler to provide virtual button detection
{
    //virtual buttons
    public GameObject vButtonSelect;
    public GameObject vButtonSpawn;

    //vaariables for moving ARcam
    //public Camera ARcam;
    public GameObject Cam;
    public GameObject[] markerArray;
    public GameObject focalPointCockpit, focalPointMid, focalPointStern;
    public float speed = 0.1f;
    Vector3 currentPos;
    Vector3 endPos;
    
    //application states
    public enum SelectableObjects { Engine, ControlEngineCar, WingEngineCar, RearEngineCar, R34, Wheel,
                                    Marker1, Marker2, Marker3, Marker4, Marker5, Marker6, Marker7, Marker8, Marker9, Marker10, Marker11, Marker12,
                                    Blank };
    public SelectableObjects objects;
    
    //raycast for object selection
    public RaycastHit hitInfo;
    LineRenderer rayLine;
    public Material LRmat1, LRmat2;
    public AudioSource rayAudio;

    //used to display information
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

        objects = SelectableObjects.Blank; //clears any UI text from being displayed on start
    }

    void Update()
    {
        AimLine();
        SelectedObjects();


        //if (ARcam.transform.position == endPos) //removes UI text "moving" when ARcam has reached its destination
        //{
        //    header.text = "";
        //    body.text = "";
        //}
    }


    //Called when virtual button is blocked from device view by user interaction 
    public void OnButtonPressed(VirtualButtonBehaviour vButton)
    {
        if (vButton.gameObject.name == "VirtualButton_select")
        {
            Debug.Log("SELECT BUTTON PRESSED");

            rayLine.material = LRmat2; //changes appearance of line renderer for duration of button press
            rayLine.SetWidth(1, 1); //increases line renderer width for duration of button press

            if (Physics.Raycast(transform.position, transform.forward, out hitInfo)) //gets information from object hit by raycast
            {
                Debug.Log(hitInfo.transform.name);

                if (hitInfo.collider)
                    rayLine.SetPosition(1, hitInfo.point);
            }

            SearchObjects(); //function compares name of object hit by raycast to strings, to select next application state
        }
        if (vButton.gameObject.name == "VirtualButton_spawn")
        {
            Debug.Log("SPAWN BUTTON PRESSED");
            //_deployStageOnce.OnInteractiveHitTest(result);
        }
    }

    //called when blocked virtual button is recognised by device 
    public void OnButtonReleased(VirtualButtonBehaviour vButton)
    {
        if (vButton.gameObject.name == "VirtualButton_select")
        {
            Debug.Log("Select button RELEASED");

            rayLine.material = LRmat1; //sets linerenderer material to default
            rayLine.SetWidth(0.2f, 0.2f); //sets linerenderer width to default
        }
        if (vButton.gameObject.name == "VirtualButton_spawn")
        {
            Debug.Log("Spawn button RELEASED");
            rayLine.enabled = false;
        }
    }


    //makes raycast visible in application. Allows user to see where Vuforia controller is aiming before pressing virtual button.
    void AimLine()
    {
        rayLine.SetPosition(0, transform.position);

        Debug.DrawRay(transform.position, transform.forward * 1000, Color.green);

        rayLine.SetPosition(1, transform.forward * 1000);
    }


    //compares object hit by raycast to strings
    //result decides the next application enum state
    void SearchObjects()
    {
        //airship colliders
        if (hitInfo.transform.name == "R34")
        {
            Debug.Log("R34");
            objects = SelectableObjects.R34;
        }
        if (hitInfo.transform.name == "Engine")
        {
            Debug.Log("Engine");
            objects = SelectableObjects.Engine;
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

        //movement marker colliders
        if (hitInfo.transform.name == "Marker1")
        {
            Debug.Log("Marker1");
            objects = SelectableObjects.Marker1;
        }
        if (hitInfo.transform.name == "Marker2")
        {
            Debug.Log("Marker2");
            objects = SelectableObjects.Marker2;
        }
        if (hitInfo.transform.name == "Marker3")
        {
            Debug.Log("Marker3");
            objects = SelectableObjects.Marker3;
        }
        if (hitInfo.transform.name == "Marker4")
        {
            Debug.Log("Marker4");
            objects = SelectableObjects.Marker4;
        }
        if (hitInfo.transform.name == "Marker5")
        {
            Debug.Log("Marker5");
            objects = SelectableObjects.Marker5;
        }
        if (hitInfo.transform.name == "Marker6")
        {
            Debug.Log("Marker6");
            objects = SelectableObjects.Marker6;
        }
        if (hitInfo.transform.name == "Marker7")
        {
            Debug.Log("Marker7");
            objects = SelectableObjects.Marker7;
        }
        if (hitInfo.transform.name == "Marker8")
        {
            Debug.Log("Marker8");
            objects = SelectableObjects.Marker8;
        }
        if (hitInfo.transform.name == "Marker9")
        {
            Debug.Log("Marker9");
            objects = SelectableObjects.Marker9;
        }
        if (hitInfo.transform.name == "Marker10")
        {
            Debug.Log("Marker10");
            objects = SelectableObjects.Marker10;
        }
        if (hitInfo.transform.name == "Marker11")
        {
            Debug.Log("Marker11");
            objects = SelectableObjects.Marker11;
        }
        if (hitInfo.transform.name == "Marker12")
        {
            Debug.Log("Marker12");
            objects = SelectableObjects.Marker12;
        }
    }

   //uses enum value to select application state
   //each case will either display information and play visual effect (if a selectable object), or is used to reposition the ARcam to its position (if a marker).
   void SelectedObjects()
    {
        switch(objects)
        {
            //selectable objects:
            //display information, object selected is highlighted.
            case SelectableObjects.ControlEngineCar:
                header.text = "Control and Front Engine Car";
                body.text = "The front gondola comprised of two compartments separated by a narrow gap, intended to prevent vibrations from affecting the equipment.";
                Debug.Log("ControlEngineCar");
                break;
            case SelectableObjects.WingEngineCar:
                header.text = "Wing Engine Car";
                body.text = "Two 'wing' gondolas each housed an engine with a reversing gear - a refinement that enabled the airship to be operated if those in the main control-cabin failed.";
                Debug.Log("WingEngineCar");
                break;
            case SelectableObjects.RearEngineCar:
                header.text = "Rear Engine Car";
                body.text = "The rear car, like the Front, was ringed with a rail to assist handlers and two 'bumping bags' of compressed air were positioned underneath to help cushion landing shocks.";
                Debug.Log("RearEngineCar");
                break;
            case SelectableObjects.Engine:
                header.text = "Engines";
                body.text = "Each of the five engines was a Sunbeam 'Maori'. No Rolls Royce engines could be made available as all those produced were now reserved for aeroplane use.";
                Debug.Log("Engine");
                break;
            case SelectableObjects.R34:
                header.text = "Hull";
                body.text = "Running almost the entire length of the ship was a long keel corridor, consisting of a succession of A-shaped frames.";
                Debug.Log("R34");
                break;
            case SelectableObjects.Wheel:
                header.text = "Steering";
                body.text = "Each engine had twelve water- cooled cylinders, which were intended to produce full power at a theoretical 2,100 rpm, although in practice it was rare for 1,600 r pm to be exceeded.";
                Debug.Log("Wheel");
                break;

            //markers:
            //lerp ARcam towards their transform
            case SelectableObjects.Marker1:
                header.text = "Moving to waypoint";
                body.text = "";
                Debug.Log("marker1");
                    //movement
                currentPos = Cam.transform.position;
                endPos = markerArray[0].transform.position;
                endPos.y = -23;
                Cam.transform.position = Vector3.Lerp(currentPos, endPos, speed);
                Cam.transform.LookAt(focalPointCockpit.transform);
                break;
            case SelectableObjects.Marker2:
                header.text = "Moving to waypoint";
                body.text = "";
                Debug.Log("marker2");
                    //movement
                currentPos = Cam.transform.position;
                endPos = markerArray[1].transform.position;
                endPos.y = -23;
                Cam.transform.position = Vector3.Lerp(currentPos, endPos, speed);
                Cam.transform.LookAt(focalPointCockpit.transform);
                break;
            case SelectableObjects.Marker3:
                header.text = "Moving to waypoint";
                body.text = "";
                Debug.Log("marker3");
                    //movement
                currentPos = Cam.transform.position;
                endPos = markerArray[2].transform.position;
                endPos.y = -23;
                Cam.transform.position = Vector3.Lerp(currentPos, endPos, speed);
                Cam.transform.LookAt(focalPointCockpit.transform);
                break;
            case SelectableObjects.Marker4:
                header.text = "Moving to waypoint";
                body.text = "";
                Debug.Log("marker4");
                    //movement
                currentPos = Cam.transform.position;
                endPos = markerArray[3].transform.position;
                endPos.y = -23;
                Cam.transform.position = Vector3.Lerp(currentPos, endPos, speed);
                Cam.transform.LookAt(focalPointCockpit.transform);
                break;
            case SelectableObjects.Marker5:
                header.text = "Moving to waypoint";
                body.text = "";
                Debug.Log("marker5");
                    //movement
                currentPos = Cam.transform.position;
                endPos = markerArray[4].transform.position;
                endPos.y = -23;
                Cam.transform.position = Vector3.Lerp(currentPos, endPos, speed);
                Cam.transform.LookAt(focalPointCockpit.transform);
                break;
            case SelectableObjects.Marker6:
                header.text = "Moving to waypoint";
                body.text = "";
                Debug.Log("marker6");
                    //movement
                currentPos = Cam.transform.position;
                endPos = markerArray[5].transform.position;
                endPos.y = -23;
                Cam.transform.position = Vector3.Lerp(currentPos, endPos, speed);
                Cam.transform.LookAt(focalPointCockpit.transform);
                break;
            case SelectableObjects.Marker7:
                header.text = "Moving to waypoint";
                body.text = "";
                Debug.Log("marker7");
                    //movement
                currentPos = Cam.transform.position;
                endPos = markerArray[6].transform.position;
                endPos.y = -23;
                Cam.transform.position = Vector3.Lerp(currentPos, endPos, speed);
                Cam.transform.LookAt(focalPointMid.transform);
                break;
            case SelectableObjects.Marker8:
                header.text = "Moving to waypoint";
                body.text = "";
                Debug.Log("marker8");
                    //movement
                currentPos = Cam.transform.position;
                endPos = markerArray[7].transform.position;
                endPos.y = -23;
                Cam.transform.position = Vector3.Lerp(currentPos, endPos, speed);
                Cam.transform.LookAt(focalPointMid.transform);
                break;
            case SelectableObjects.Marker9:
                header.text = "Moving to waypoint";
                body.text = "";
                Debug.Log("marker9");
                    //movement
                currentPos = Cam.transform.position;
                endPos = markerArray[8].transform.position;
                endPos.y = -23;
                Cam.transform.position = Vector3.Lerp(currentPos, endPos, speed);
                Cam.transform.LookAt(focalPointMid.transform);
                break;
            case SelectableObjects.Marker10:
                header.text = "Moving to waypoint";
                body.text = "";
                Debug.Log("marker10");
                    //movement
                currentPos = Cam.transform.position;
                endPos = markerArray[9].transform.position;
                endPos.y = -23;
                Cam.transform.position = Vector3.Lerp(currentPos, endPos, speed);
                Cam.transform.LookAt(focalPointMid.transform);
                break;
            case SelectableObjects.Marker11:
                header.text = "Moving to waypoint";
                body.text = "";
                Debug.Log("marker11");
                //movement
                currentPos = Cam.transform.position;
                endPos = markerArray[10].transform.position;
                endPos.y = -23;
                Cam.transform.position = Vector3.Lerp(currentPos, endPos, speed);
                Cam.transform.LookAt(focalPointStern.transform);
                break;
            case SelectableObjects.Marker12:
                header.text = "Moving to waypoint";
                body.text = "";
                Debug.Log("marker12");
                //movement
                currentPos = Cam.transform.position;
                endPos = markerArray[11].transform.position;
                endPos.y = -23;
                Cam.transform.position = Vector3.Lerp(currentPos, endPos, speed);
                Cam.transform.LookAt(focalPointStern.transform);
                break;

            //show no UI at start
            case SelectableObjects.Blank:
                header.text = "";
                body.text = "";
                Debug.Log("Blank");
                break;
            //default
            default:
                header.text = "";
                body.text = "";
                Debug.Log("defaultcase");
                break;
        }
    }
}
