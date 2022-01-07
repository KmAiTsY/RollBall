using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSct : MonoBehaviour
{
    public Transform target;
    private Camera cam;
    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Vector3 v3 = new Vector3(0, target.position.y + 3f, target.position.z - 5f);
        cam.transform.position = v3;
        cam.transform.LookAt(target.position);
    }
}
