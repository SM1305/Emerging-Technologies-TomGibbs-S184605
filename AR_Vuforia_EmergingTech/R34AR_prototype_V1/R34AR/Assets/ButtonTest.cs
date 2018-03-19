using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    public Button testButton;
    public Text testText;
    bool toggleText;

	void Start ()
    {
        testButton.enabled = true;
        testText.enabled = false;
        toggleText = false;
	}
	
	void Update ()
    {
		
	}

    public void ButtonPress()
    {
        if (toggleText)
        {
            testText.enabled = false;
            toggleText = false;
        }
        else if (!toggleText)
        {
            testText.enabled = true;
            toggleText = true;
        }
    }
}
