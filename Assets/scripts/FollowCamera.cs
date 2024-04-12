using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    public Transform target; // Reference to the car object
    public Vector3 offset; // Offset of the camera from the target

    void LateUpdate()
    {
        if (target == null)
            return;

        // Set the position of the camera to be offset from the car's position
        transform.position = target.position + offset;

        // Make the camera look at the car
        transform.LookAt(target);
    }
}
