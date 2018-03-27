using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OceanMarkers : MonoBehaviour
{
    [Header("Hierarchy Objects")]
    //public GUIText Title;
    //public GUIText Time;
    //public GUIText Desctiption;
    public TextMesh Title;
    public TextMesh Time;
    public TextMesh Desctiption;

    [Header("Marker Management")]
    //public GameObject markers;
    public GameObject[] markersArray;
    public int markersIndex = 0;

    private GameObject currentMarker;
    private GameObject nextMarker;


    void Start ()
    {
        Title = GetComponent<TextMesh>();
        Time = GetComponent<TextMesh>();
        Desctiption = GetComponent<TextMesh>();


        currentMarker = markersArray[markersIndex];
        nextMarker = markersArray[markersIndex+1];
	}

	void Update ()
    {
        SwitchMarker();

        Debug.Log("THE MARKERS INDEX IS: " + markersIndex);
	}

    void SwitchMarker()
    {
        switch (markersIndex)
        {
            case 1:
                Debug.Log("CASE 1");
                Title.text = "Title 1";
                Time.text = "Time 1";
                Desctiption.text = "Description 1";
                break;
            case 2:
                Debug.Log("CASE 2");
                Title.text = "Title 2";
                Time.text = "Time 2";
                Desctiption.text = "Description 2";
                break;
            case 3:
                Debug.Log("CASE 3");
                Title.text = "Title 3";
                Time.text = "Time 3";
                Desctiption.text = "Description 3";
                break;
            case 4:
                Debug.Log("CASE 4");
                Title.text = "Title 4";
                Time.text = "Time 4";
                Desctiption.text = "Description 4";
                break;
            case 5:
                Title.text = "Title 5";
                Time.text = "Time 5";
                Desctiption.text = "Description 5";
                break;
            case 6:
                Title.text = "Title 6";
                Time.text = "Time 6";
                Desctiption.text = "Description 6";
                break;
            case 7:
                Title.text = "Title 7";
                Time.text = "Time 7";
                Desctiption.text = "Description 7";
                break;
            case 8:
                Title.text = "Title 8";
                Time.text = "Time 8";
                Desctiption.text = "Description 8";
                break;
            case 9:
                Title.text = "Title 9";
                Time.text = "Time 9";
                Desctiption.text = "Description 9";
                break;
            case 10:
                Title.text = "Title 10";
                Time.text = "Time 10";
                Desctiption.text = "Description 10";
                break;
            case 11:
                Title.text = "Title 11";
                Time.text = "Time 11";
                Desctiption.text = "Description 11";
                break;
        }
    }   
}
