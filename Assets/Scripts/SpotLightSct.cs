using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightSct : MonoBehaviour
{
    public Transform ball;

    private void Start()
    {
        ball = GameObject.Find("Ball").transform;
    }
    void Update()
    {
        this.transform.LookAt(ball.position);
    }
}
