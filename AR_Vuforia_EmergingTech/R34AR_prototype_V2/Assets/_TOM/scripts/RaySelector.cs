using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RaySelector : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vButtonSelect;
    public GameObject vButtonSpawn;

    public GameObject detector;

    private LineRenderer rayLine;
    private WaitForSeconds rayDuration = new WaitForSeconds(1f);
    private AudioSource rayAudio;

    DeployStageOnce _deployStageOnce;


    void Start ()
    {
        vButtonSelect = GameObject.Find("VirtualButton_select");
        vButtonSelect.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        vButtonSpawn = GameObject.Find("VirtualButton_spawn");
        vButtonSpawn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        rayAudio = GetComponent<AudioSource>();
        rayLine = GetComponent<LineRenderer>();
        rayLine.enabled = false;
	}
	
	void Update ()
    {
        Debug.Log("update is printing");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("click is working");
            Detect();
        }
	}

    public void OnButtonPressed(VirtualButtonBehaviour vButton)
    {
        if (vButton.gameObject.name == "VirtualButton_select")
            Debug.Log("SELECT BUTTON PRESSED");
        if (vButton.gameObject.name == "VirtualButton_spawn")
            Debug.Log("SPAWN BUTTON PRESSED");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vButton)
    {
        if (vButton.gameObject.name == "VirtualButton_select")
            Debug.Log("Select button RELEASED");
        if (vButton.gameObject.name == "VirtualButton_spawn")
        {
            Debug.Log("Spawn button RELEASED");
            _deployStageOnce.OnInteractiveHitTest(result);
        }
    }

    void Detect()
    {
            RaycastHit hitInfo;
        //if (Physics.Raycast(detector.transform.position, detector.transform.forward, out hitInfo))
        //{
        Physics.Raycast(detector.transform.position, detector.transform.forward, out hitInfo);

            Debug.Log("detect is being called");
            Debug.DrawRay(detector.transform.position, detector.transform.forward * 100, Color.green);
            //Debug.Log(hitInfo.transform.name);
        //}
    }

    private IEnumerator VisibleRaycast()
    {
        rayAudio.Play();
        rayLine.enabled = true;
        yield return rayDuration;
        rayLine.enabled = false;
    }
}
