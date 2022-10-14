using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public GameObject head;
    public GameObject leftHand;

    private float flyingSpeed = 0.04f;
    private bool isFlying = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfFlying();
        FlyIfFlying();
    }

    private void CheckIfFlying()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            isFlying = true;
        }

        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            isFlying = false;
        }
    }

    private void FlyIfFlying()
    {
        if (isFlying == true)
        {
            Vector3 flyDirection = leftHand.transform.position - head.transform.position;
            transform.position += flyDirection.normalized * flyingSpeed;
        }
    }
}
