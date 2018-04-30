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
                Header.text = "Wednesday July 2nd 00:47";
                Description.text = "At the Airship Station at Eastbourne the R34 Britain's largest and most efficient Rigid Airship is about to start upon her 3,000 miles journey across the Atlantic bound for Long Island New York.\n" +
                                    "8 officers and 22 men dressed in their flying clothes having had an excellent dinner to fortify them for their long journey and are ready to climb aboard.";
                break;
            case 2:
                currentMarker = markersArray[1];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Wednesday July 2nd 18:20";
                Description.text = "Flying at a height of 2,000 feet and have taken 17 hours to travel 610 miles. Speed is distinctly slow, \n" +
                                    "have been running for a large part of the time on 3 engines, with 2 engines resting. It must be remembered that engines have to  be nursed for the return journey.";
                prevMarker = markersArray[0];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 3:
                currentMarker = markersArray[2];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Thursday July 3rd 04:20";
                Description.text = "Last message from East Fortune. Now beyond their wireless range. Well over half way between Ireland and Newfoundland.";
                prevMarker = markersArray[1];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 4:
                currentMarker = markersArray[3];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Thursday July 3rd 14:47";
                Description.text = "Wind rising sea beginning to get rough visibility 1 mile";
                prevMarker = markersArray[2];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 5:
                currentMarker = markersArray[4];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "TFriday July 4th 09:30";
                Description.text = "A message reaches us from the Governor of Newfoundland. On behalf of Newfoundland I greet you as you pass us on your enterprising journey.";
                prevMarker = markersArray[3];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 6:
                currentMarker = markersArray[5];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Friday July 4th 16:30";
                Description.text = "Steering a course for Halifax, Nova Scotia. Air speed 35 and a half knots on forward and 2 wing engines.\n" +
                                    "Fresh following wind of about 10 miles an hour, so we are making good 45 and a half knots on 3 engines which is excellent.";
                prevMarker = markersArray[4];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 7:
                currentMarker = markersArray[6];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Friday July 4th 20:30";
                Description.text = "Land again in sight. Light house is giving 4 flashes. We have averaged 32 and a half knots between Newfoundland and Nova Scotia.\n" +
                                    "At this rate should make Halifax by 2:30 tomorrow.";
                prevMarker = markersArray[5];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 8:
                currentMarker = markersArray[7];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Saturday July 5th 11:10  ";
                Description.text = "Petrol supply is distinctly serious. Cannot afford to run all 5 engines. Violent temperature bumps caused by rapid variation of sea temperature beneath air ship.\n" +
                                    "Ship is first lifted 400 feet then dropped 500 feet. Scott sees the tail of the airship bend under the strain.";
                prevMarker = markersArray[6];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 9:
                currentMarker = markersArray[8];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Saturday July 5th 23:30";
                Description.text = "Things don't look well for getting through to New York.";
                prevMarker = markersArray[7];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 10:
                currentMarker = markersArray[9];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Sunday July 6th 08:00";
                Description.text = "Petrol situation had become desperate and so must land at Montauk. All feel disappointed.\n" +
                                    "Spoke to American destroyer who had come to help but declined her assistance.";
                prevMarker = markersArray[8];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
            case 11:
                currentMarker = markersArray[10];
                PS = currentMarker.GetComponentInChildren<ParticleSystem>();
                PS.Play();
                Header.text = "Thursday July 10th 03:54";
                Description.text = "New York flying at 1,500 feet to avoid bumping into the skyscrapers.";
                prevMarker = markersArray[9];
                prevPS = prevMarker.GetComponentInChildren<ParticleSystem>();
                prevPS.Stop();
                break;
        }
    }   
}
