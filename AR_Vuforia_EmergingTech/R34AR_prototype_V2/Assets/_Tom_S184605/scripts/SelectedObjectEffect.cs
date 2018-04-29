using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedObjectEffect : MonoBehaviour
{
    RaySelector _raySelector;
    public GameObject RaySelectorGO;

    public GameObject R34;
    Renderer R34renderer;

    public GameObject propeller1, propeller2, propeller3, propeller4;
    Renderer propeller1renderer, propeller2renderer, propeller3renderer, propeller4renderer;

    public GameObject ControlEngineCar;
    Renderer ControlEngineCarrenderer;
    Material[] ControlEngineCarmat;

    public GameObject WingEngine1, WingEngine2;
    Renderer WingEngine1renderer, WingEngine2renderer;
    Material[] WingEngine1mat, WingEngine2mat;

    public GameObject RearEngine;
    Renderer RearEnginerenderer;
    Material[] RearEnginemat;

    public GameObject[] Markers;
    Renderer markerRenderer1, markerRenderer2, markerRenderer3, markerRenderer4, markerRenderer5, markerRenderer6, markerRenderer7, markerRenderer8, markerRenderer9, markerRenderer10, markerRenderer11, markerRenderer12;


    Color normalColour;
    Color highlight = new Color(1, 1, 0);

    void Start()
    {
        _raySelector = RaySelectorGO.GetComponent<RaySelector>();

        R34renderer = R34.GetComponent<Renderer>();

        propeller1renderer = propeller1.GetComponent<Renderer>();
        propeller2renderer = propeller2.GetComponent<Renderer>();
        propeller3renderer = propeller3.GetComponent<Renderer>();
        propeller4renderer = propeller4.GetComponent<Renderer>();

        ControlEngineCarrenderer = ControlEngineCar.GetComponent<Renderer>();
        ControlEngineCarmat = ControlEngineCarrenderer.materials;

        WingEngine1renderer = WingEngine1.GetComponent<MeshRenderer>();
        WingEngine1mat = WingEngine1renderer.materials;
        WingEngine2renderer = WingEngine2.GetComponent<MeshRenderer>();
        WingEngine2mat = WingEngine2renderer.materials;

        RearEnginerenderer = RearEngine.GetComponent<Renderer>();
        RearEnginemat = RearEnginerenderer.materials;

        markerRenderer1 = Markers[0].GetComponent<Renderer>();
        markerRenderer2 = Markers[1].GetComponent<Renderer>();
        markerRenderer3 = Markers[2].GetComponent<Renderer>();
        markerRenderer4 = Markers[3].GetComponent<Renderer>();
        markerRenderer5 = Markers[4].GetComponent<Renderer>();
        markerRenderer6 = Markers[5].GetComponent<Renderer>();
        markerRenderer7 = Markers[6].GetComponent<Renderer>();
        markerRenderer8 = Markers[7].GetComponent<Renderer>();
        markerRenderer9 = Markers[8].GetComponent<Renderer>();
        markerRenderer10 = Markers[9].GetComponent<Renderer>();
        markerRenderer11 = Markers[10].GetComponent<Renderer>();
        markerRenderer12 = Markers[11].GetComponent<Renderer>();

        normalColour = R34renderer.material.color;
    }

    void Update()
    {
        if (_raySelector.objects == RaySelector.SelectableObjects.R34)
            R34renderer.material.color = highlight;
        else
            R34renderer.material.color = normalColour;

        if (_raySelector.objects == RaySelector.SelectableObjects.Engine)
        {
            propeller1renderer.material.color = highlight;
            propeller2renderer.material.color = highlight;
            propeller3renderer.material.color = highlight;
            propeller4renderer.material.color = highlight;

            propeller1.transform.Rotate(Vector3.right * Time.deltaTime * 50);
            propeller2.transform.Rotate(Vector3.right * Time.deltaTime * 50);
            propeller3.transform.Rotate(Vector3.right * Time.deltaTime * 50);
            propeller4.transform.Rotate(Vector3.right * Time.deltaTime * 50);
        }
        else
        {
            propeller1renderer.material.color = normalColour;
            propeller2renderer.material.color = normalColour;
            propeller3renderer.material.color = normalColour;
            propeller4renderer.material.color = normalColour;

            propeller1.transform.Rotate(0f, 0f, 0f, Space.Self);
            propeller2.transform.Rotate(0f, 0f, 0f, Space.Self);
            propeller3.transform.Rotate(0f, 0f, 0f, Space.Self);
            propeller4.transform.Rotate(0f, 0f, 0f, Space.Self);
        }

        if (_raySelector.objects == RaySelector.SelectableObjects.ControlEngineCar)
        {
            //ControlEngineCarrenderer.material.color = highlight;
            ControlEngineCarmat[0].color = highlight;
            ControlEngineCarmat[1].color = highlight;
            ControlEngineCarmat[2].color = highlight;
        }
        else
        {
            //ControlEngineCarrenderer.material.color = normalColour;
            ControlEngineCarmat[0].color = normalColour;
            ControlEngineCarmat[1].color = normalColour;
            ControlEngineCarmat[2].color = normalColour;
        }

        if (_raySelector.objects == RaySelector.SelectableObjects.WingEngineCar)
        {
            //WingEngine1renderer.material.color = highlight;
            WingEngine1mat[0].color = highlight;
            WingEngine1mat[1].color = highlight;
            WingEngine1mat[2].color = highlight;
            WingEngine1mat[3].color = highlight;
            //WingEngine2renderer.material.color = highlight;
            WingEngine2mat[0].color = highlight;
            WingEngine2mat[1].color = highlight;
            WingEngine2mat[2].color = highlight;
            WingEngine2mat[3].color = highlight;
        }
        else
        {
            //WingEngine1renderer.material.color = normalColour;
            WingEngine1mat[0].color = normalColour;
            WingEngine1mat[1].color = normalColour;
            WingEngine1mat[2].color = normalColour;
            WingEngine1mat[3].color = normalColour;
            //WingEngine2renderer.material.color = normalColour;
            WingEngine2mat[0].color = normalColour;
            WingEngine2mat[1].color = normalColour;
            WingEngine2mat[2].color = normalColour;
            WingEngine2mat[3].color = normalColour;
        }

        if (_raySelector.objects == RaySelector.SelectableObjects.RearEngineCar)
        {
            //RearEnginerenderer.material.color = highlight;
            RearEnginemat[0].color = highlight;
            RearEnginemat[1].color = highlight;
            RearEnginemat[2].color = highlight;
        }
        else
        {
            //RearEnginerenderer.material.color = normalColour;
            RearEnginemat[0].color = normalColour;
            RearEnginemat[1].color = normalColour;
            RearEnginemat[2].color = normalColour;
        }

        if (_raySelector.objects == RaySelector.SelectableObjects.Marker1)
            markerRenderer1.material.color = highlight;
        else
            markerRenderer1.material.color = normalColour;

        if (_raySelector.objects == RaySelector.SelectableObjects.Marker2)
            markerRenderer2.material.color = highlight;
        else
            markerRenderer2.material.color = normalColour;

        if (_raySelector.objects == RaySelector.SelectableObjects.Marker3)
            markerRenderer3.material.color = highlight;
        else
            markerRenderer3.material.color = normalColour;

        if (_raySelector.objects == RaySelector.SelectableObjects.Marker4)
            markerRenderer4.material.color = highlight;
        else
            markerRenderer4.material.color = normalColour;

        if (_raySelector.objects == RaySelector.SelectableObjects.Marker5)
            markerRenderer5.material.color = highlight;
        else
            markerRenderer5.material.color = normalColour;

        if (_raySelector.objects == RaySelector.SelectableObjects.Marker6)
            markerRenderer6.material.color = highlight;
        else
            markerRenderer6.material.color = normalColour;

        if (_raySelector.objects == RaySelector.SelectableObjects.Marker7)
            markerRenderer7.material.color = highlight;
        else
            markerRenderer7.material.color = normalColour;

        if (_raySelector.objects == RaySelector.SelectableObjects.Marker8)
            markerRenderer8.material.color = highlight;
        else
            markerRenderer8.material.color = normalColour;

        if (_raySelector.objects == RaySelector.SelectableObjects.Marker9)
            markerRenderer9.material.color = highlight;
        else
            markerRenderer9.material.color = normalColour;

        if (_raySelector.objects == RaySelector.SelectableObjects.Marker10)
            markerRenderer10.material.color = highlight;
        else
            markerRenderer10.material.color = normalColour;

        if (_raySelector.objects == RaySelector.SelectableObjects.Marker11)
            markerRenderer11.material.color = highlight;
        else
            markerRenderer11.material.color = normalColour;

        if (_raySelector.objects == RaySelector.SelectableObjects.Marker12)
            markerRenderer12.material.color = highlight;
        else
            markerRenderer12.material.color = normalColour;
    }
}
