using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadertest : MonoBehaviour
{
    Shader shader1;
    Shader shader2;
    public Renderer rend;


	void Start ()
    {
        rend = GetComponent<Renderer>();
        shader1 = Shader.Find("Standard");
        shader2 = Shader.Find("N3K/Outline");
        rend.material.shader = shader1;
    }
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rend.material.shader = shader2;
            Debug.Log("shader 2");
        }
        if (Input.GetMouseButtonUp(0))
        {
            rend.material.shader = shader1;
            Debug.Log("shader 1");
        }
    }
}
