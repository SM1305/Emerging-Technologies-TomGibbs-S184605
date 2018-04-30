using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GPSMarkerlessTrack : MonoBehaviour
{
    private float originalLatitude;
    private float originalLongitude;
    private float currentLongitude;
    private float currentLatitude;

    private GameObject distanceTextObject;
    private double distance;

    private bool setOriginalValues = true;

    private Vector3 targetPosition;
    private Vector3 originalPosition;

    private float speed = 10f; //.1

    IEnumerator GetCoordinates()
    {
        while (true)
        {
            if (!Input.location.isEnabledByUser)
                yield break;


            Input.location.Start(0.5f, .1f); // (1f, .1f); // watch multiplication of distance below!!! //distance update, amount pass


            int maxWait = 20;
            while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
            {
                yield return new WaitForSeconds(1);
                maxWait--;
            }

            if (maxWait < 1)
            {
                print("Timed out");
                yield break;
            }

            if (Input.location.status == LocationServiceStatus.Failed)
            {
                print("Unable to determine device location");
                yield break;
            }
            else
            {
                print("Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);

                //set original values on launch
                if (setOriginalValues)
                {
                    originalLatitude = Input.location.lastData.latitude;
                    originalLongitude = Input.location.lastData.longitude;
                    setOriginalValues = false;
                }

                //overwrite current lat and lon everytime
                currentLatitude = Input.location.lastData.latitude;
                currentLongitude = Input.location.lastData.longitude;

                //distance between playerStartPos - playerCurrPos
                Calc(originalLatitude, originalLongitude, currentLatitude, currentLongitude);

            }
            Input.location.Stop();
        }
    }

    //distance between two coordinate sets //accounts for curvature of the earth
    public void Calc(float lat1, float lon1, float lat2, float lon2)
    {

        var R = 6378.137; // Radius of earth in KM
        var dLat = lat2 * Mathf.PI / 180 - lat1 * Mathf.PI / 180;
        var dLon = lon2 * Mathf.PI / 180 - lon1 * Mathf.PI / 180;
        float a = Mathf.Sin(dLat / 2) * Mathf.Sin(dLat / 2) +
          Mathf.Cos(lat1 * Mathf.PI / 180) * Mathf.Cos(lat2 * Mathf.PI / 180) *
          Mathf.Sin(dLon / 2) * Mathf.Sin(dLon / 2);
        var c = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
        distance = R * c;
        distance = distance * 1000f; // meters
        distanceTextObject.GetComponent<Text>().text = "Distance: " + distance;
        //convert distance from double to float
        float distanceFloat = (float)distance;
        //set ship pos
        targetPosition = originalPosition - new Vector3(0, 0, distanceFloat * 10);
        //multiply distance for stronger effect

    }

    void Start()
    {
        distanceTextObject = GameObject.FindGameObjectWithTag("distanceText");
        StartCoroutine("GetCoordinates");
        targetPosition = transform.position;
        originalPosition = transform.position;
    }

    void Update()
    {
        //linearly interpolate from current position to target position
        transform.position = Vector3.Lerp(transform.position, targetPosition, speed);
    }
}
