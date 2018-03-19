using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SwipeRotate : MonoBehaviour
{
    public float smooth = 1f;
    private Quaternion targetRotation;


    public float spinSpeed = 4f;
    public float degreesPerSecond = 45f;
    public float totalRotation = 0f;

    private GestureListener gestureListener;


    void Start()
    {
        targetRotation = transform.rotation;

        // hide mouse cursor
        Cursor.visible = false;

        // get the gestures listener
        gestureListener = Camera.main.GetComponent<GestureListener>();
    }

    void Update()
    {
        // dont run Update() if there is no user
        KinectManager kinectManager = KinectManager.Instance;

        if (gestureListener.IsSwipeLeft())
        {
            transform.Rotate(Vector3.up * 90);
        }
        if (gestureListener.IsSwipeRight())
            transform.Rotate(Vector3.up * -90);
        if (gestureListener.IsJumping())
            transform.Rotate(Vector3.right * 90);
        if (gestureListener.IsSquatting())
            transform.Rotate(Vector3.right * -90);



    }
}
