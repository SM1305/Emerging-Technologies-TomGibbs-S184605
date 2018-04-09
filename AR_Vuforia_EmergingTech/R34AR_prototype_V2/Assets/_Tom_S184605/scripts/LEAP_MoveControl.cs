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
    {

	}
	
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

        //Debug.Log("Pitch: " + handPalmPitch);
        //Debug.Log("Roll: " + handPalmRoll);
        //Debug.Log("Yaw: " + handPalmYaw);
        Debug.Log("Wrist Pich " + handWristPitch);


        // movement of objects
        if (handPalmPitch > -0.5f /*&& handPalmPitch < 3f*/)
        {
            transform.Translate(new Vector3(0, 0, -1 * Time.deltaTime * 3));
            //Debug.Log("forward");
        }
        if (handPalmPitch < -1.6f)
        {
            transform.Translate(new Vector3(0, 0, 1 * Time.deltaTime * 3));
            //Debug.Log("backward");
        }

        if (handPalmRoll < -1.3f)
        {
            transform.Rotate(new Vector3(0, 1, 0 * Time.deltaTime * 3));
            //Debug.Log("rot right");
        }
        if (handPalmRoll > 1.1f)
        {
            transform.Rotate(new Vector3(0, -1, 0 * Time.deltaTime * 3));
            //Debug.Log("rot left");
        }

        if (handPalmYaw < -1.5f)
        {
            transform.Translate(new Vector3(-1, 0, 0 * Time.deltaTime * 3));
            //Debug.Log("strafe left");
        }
        if (handPalmYaw > 0.02f)
        {
            transform.Translate(new Vector3(1, 0, 0 * Time.deltaTime * 3));
            //Debug.Log("strafe right");
        }
    }
}
