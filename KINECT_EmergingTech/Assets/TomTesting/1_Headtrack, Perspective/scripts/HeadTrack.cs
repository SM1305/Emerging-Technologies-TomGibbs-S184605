using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeadTrack : MonoBehaviour
{
    public GameObject HeadTracker;
    public Camera mainCam;

	void Start ()
    {
        HeadTracker.transform.position = mainCam.transform.position;
	}

    public static float RoundToHalf(float roundThis)
    {
        return roundThis = Mathf.Round(roundThis * 2f) * 0.5f;
    }
	
	void Update ()
    {
        Vector3 updatePos;
        float x, y, z;
        x = HeadTracker.transform.position.x * 15;
        RoundToHalf(x);
        y = HeadTracker.transform.position.y * 5 - 8f;
        RoundToHalf(y);
        //if (y < -2)
        //    y = y * 2;
        //if (y > 3)
        //    y = y * 2;
        z = -17.5f;
        updatePos.x = x;
        updatePos.y = y;
        updatePos.z = z;
        mainCam.transform.position = updatePos;

        if (mainCam.transform.position.x < -52)
        {
            updatePos.x = -51.99f;
        }
        if (mainCam.transform.position.x > 20)
        {
            updatePos.x = 19.99f;
        }
        if (mainCam.transform.position.y < -9)
        {
            updatePos.y = -8.99f;
        }
        if (mainCam.transform.position.y > 28)
        {
            updatePos.y = 27.99f;
        }
    }
}
