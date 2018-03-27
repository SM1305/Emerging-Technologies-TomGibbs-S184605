using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerTriggerListener : MonoBehaviour
{
    public GameObject WATER;
    OceanMarkers _OceanMarkers;

	void Start ()
    {
        _OceanMarkers = WATER.GetComponent<OceanMarkers>();
	}
	
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnterIsWorking!");
        _OceanMarkers.markersIndex++;
        //markersIndex++;
    }
}
