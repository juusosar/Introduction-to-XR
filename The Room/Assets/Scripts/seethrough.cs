using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seethrough : MonoBehaviour
{

    public Transform main_camera;

    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.parent.position - main_camera.position, transform.parent.up);
    }
}
