using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class LEAP_MoveControl : MonoBehaviour
{
    Controller controller;
    float handPalmPitch;
    float handPalmYaw;
    float handPalmRoll;
    float handWristPitch;

	void Start ()
    {}
	
	void Update ()
    {
        controller = new Controller();
        Frame frame = controller.Frame();
        List<Hand> hands = frame.Hands;
        if (frame.Hands.Count > 0)
        {
            Hand firstHand = hands[0];
        }

        handPalmPitch = hands[0].PalmNormal.Pitch;
        handPalmRoll = hands[0].PalmNormal.Roll;
        handPalmYaw = hands[0].PalmNormal.Yaw;
        handWristPitch = hands[0].WristPosition.Pitch;

        Debug.Log("Pitch: " + handPalmPitch);
        Debug.Log("Roll: " + handPalmRoll);
        Debug.Log("Yaw: " + handPalmYaw);
        Debug.Log("Wrist Pich " + handWristPitch);


        // movement of camera
        if (handPalmPitch > -2f && handPalmPitch < -1.5f)
        {
            transform.Translate(new Vector3(0, 0, 1 * Time.deltaTime * -3));
            Debug.Log("forward");
        }
        else if (handPalmPitch > -0.75f && handPalmPitch < -0.1f)
        {
            transform.Translate(new Vector3(0, 0, 1 * Time.deltaTime * 3));
            Debug.Log("backward");
        }

        if (handPalmRoll > -1.9f && handPalmRoll < -1.4f)
        {
            transform.Rotate(new Vector3(0, 1, 0 * Time.deltaTime * -0.5f));
            Debug.Log("rot right");
        }
        if (handPalmRoll > 0.84f && handPalmRoll < 1.4f)
        {
            transform.Rotate(new Vector3(0, -1, 0 * Time.deltaTime * 0.5f));
            Debug.Log("rot left");
        }
      


        //if (handPalmYaw > 0f && handPalmYaw < 1f)
        //{
        //    transform.Translate(new Vector3(1, 0, 0 * Time.deltaTime * -0.5f));
        //    //Debug.Log("strafe left");
        //}
        //if (handPalmYaw > -1.9f && handPalmYaw < 1.5f)
        //{
        //    transform.Translate(new Vector3(1, 0, 0 * Time.deltaTime * 0.5f));
        //    //Debug.Log("strafe right");
        //}
    }
}
