using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OceanMarkers : MonoBehaviour
{
    [Header("Hierarchy Objects")]
    public TextMesh Header;
    public TextMesh Description;


    [Header("Marker Management")]
    public GameObject[] markersArray;
    public int markersIndex = 0;

    private GameObject currentMarker;
    private GameObject nextMarker;
    private GameObject prevMarker;

    private ParticleSystem PS;
    private ParticleSystem nextPS;
    private ParticleSystem prevPS;


    //public bool UKtoUS;

    
    void Start ()
    {
        currentMarker = markersArray[markersIndex];
        //nextMarker = markersArray[markersIndex+1];
	}

	void Update ()
    {
        SwitchMarker();

        //currentMarker = markersArray[markersIndex];
        //PS = currentMarker.GetComponentInChildren<ParticleSystem>();
        //PS.Play();
    }

    void SwitchMarker()
    {
        switch (markersIndex)
        {
            case 1:
                currentMarker = markersArray[0];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Title 1";
                Description.text = "Description 1";
                break;
            case 2:
                currentMarker = markersArray[1];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Title 2";
                Description.text = "Description 2";
                prevMarker = markersArray[0];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 3:
                currentMarker = markersArray[2];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Title 3";
                Description.text = "Description 3";
                prevMarker = markersArray[1];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 4:
                currentMarker = markersArray[3];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Title 4";
                Description.text = "Description 4";
                prevMarker = markersArray[2];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 5:
                currentMarker = markersArray[4];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Title 5";
                Description.text = "Description 5";
                prevMarker = markersArray[3];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 6:
                currentMarker = markersArray[5];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Title 6";
                Description.text = "Description 6";
                prevMarker = markersArray[4];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 7:
                currentMarker = markersArray[6];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Title 7";
                Description.text = "Description 7";
                prevMarker = markersArray[5];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 8:
                currentMarker = markersArray[7];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Title 8";
                Description.text = "Description 8";
                prevMarker = markersArray[6];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 9:
                currentMarker = markersArray[8];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Title 9";
                Description.text = "Description 9";
                prevMarker = markersArray[7];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 10:
                currentMarker = markersArray[9];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Title 10";
                Description.text = "Description 10";
                prevMarker = markersArray[8];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 11:
                currentMarker = markersArray[10];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Title 11";
                Description.text = "Description 11";
                prevMarker = markersArray[9];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
        }
    }   
}
