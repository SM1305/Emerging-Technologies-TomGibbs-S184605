using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialtest : MonoBehaviour
{
    public Renderer rend;
    Color normalColour;
    Color highlight = new Color(1, 1, 0);
    
    void Start()
    {
        rend = GetComponent<Renderer>();
        normalColour = rend.material.color;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rend.material.color = highlight;
            Debug.Log("highlight colour");
        }
        if (Input.GetMouseButtonUp(0))
        {
            rend.material.color = normalColour;
            Debug.Log("normal colour");
        }
    }
}
