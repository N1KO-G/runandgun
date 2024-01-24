using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerCam : MonoBehaviour
{
    

    public Transform orientation;
     Transform camHolder;

    float xRotation;
    float yRotation;

 

    private void Update()
    {
        
        camHolder.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation =  Quaternion.Euler(0, yRotation, 0);
        
    }

    public void DoFov(float endValue)
    {
        GetComponent<Camera>().DOFieldOfView(endValue, 0.25f);
    }

    public void DoTilt(float zTilt)
    {
        transform.DOLocalRotate(new Vector3(0,0, zTilt), 0.25f);
    }


}
