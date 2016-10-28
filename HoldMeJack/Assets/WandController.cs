﻿using UnityEngine;
using System.Collections;

public class WandController : MonoBehaviour {

    private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
    public bool gripButtonDown = false;
    public bool gripButtonUp = false;
    public bool gripButtonPressed = false;
    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_Grip;
    public bool triggerButtonDown = false;
    public bool triggerButtonUp = false;
    public bool triggerButtonPressed = false;
    private SteamVR_Controller.Device controller {get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;


	// Use this for initialization
	void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();

	}
	
	// Update is called once per frame 
	void Update () {
        if (controller == null)
        {
            Debug.Log("Controller not intiliazeisd ofzo aids");
            return;
        }
        gripButtonDown = controller.GetPressDown(gripButton);
        gripButtonUp = controller.GetPressUp(gripButton);
        gripButtonPressed = controller.GetPress(gripButton);

        triggerButtonDown = controller.GetPressDown(triggerButton);
        triggerButtonUp = controller.GetPressUp(triggerButton);
        triggerButtonPressed = controller.GetPress(triggerButton);

        if (gripButtonDown)
        {
            Debug.log("gripbuttondown was pressed")
        }
        if (gripButtonDown)
        {
            Debug.log("4")
        }
        if (gripButtonDown)
        {
            Debug.log("gripbuttondown was pressed")
        }

    }
}