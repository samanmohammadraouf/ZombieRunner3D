using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField]  RigidbodyFirstPersonController fpsController;

    [SerializeField] float zoomIn = 20f;
    [SerializeField] float zoomOut =  60f;

    [SerializeField] float ZoomInSensitivity = 0.5f;
    [SerializeField] float ZoomOutSensitivity = 2f;

   

    bool zoomToggle = false;

    
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if (zoomToggle == false)
            {
                zoomToggle = true;
                fpsCamera.fieldOfView = zoomIn;
                fpsController.mouseLook.XSensitivity = ZoomInSensitivity;
                fpsController.mouseLook.YSensitivity = ZoomInSensitivity;
            }
            else
            {
                zoomToggle = false;
                fpsCamera.fieldOfView = zoomOut;
                fpsController.mouseLook.XSensitivity = ZoomOutSensitivity;
                fpsController.mouseLook.YSensitivity = ZoomOutSensitivity;
            }
        }
    }
}
