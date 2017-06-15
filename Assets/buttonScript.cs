using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class buttonScript : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject vbButtonObject;
    private GameObject butterflyObject;

    // Use this for initialization
    void Start () {
        vbButtonObject = GameObject.Find("actionButton");
        butterflyObject = GameObject.Find("Butterfly");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("botton Pressed");
        butterflyObject.GetComponent<Animation>().Play();
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {


        butterflyObject.GetComponent<Animation>().Stop();
        Debug.Log("button release");        

    }

}
