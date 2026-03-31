using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUpdate : MonoBehaviour
{
    // Update is called once per frame
    void LateUpdate()
    {
        if(BallMazeSetup.ballTransform != null)
        {
            Vector3 offset = new Vector3(-2f, 2.5f, -2f);
            transform.position = BallMazeSetup.ballTransform.position + offset;
            transform.LookAt(BallMazeSetup.ballTransform.position);
        }
    }
}
