using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] float force;
    private InputSys _inputSys;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    private void Awake()
    {
        _inputSys = new InputSys();
    }
    private void OnEnable()
    {
        _inputSys.Enable();
    }


    private void OnDisable()
    {
        _inputSys.Disable();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Vector2 v2 = _inputSys.Player.Touch.ReadValue<Vector2>();
        if (v2 != Vector2.zero)
        {
            text.text = v2.ToString();
            Vector3 newVector = new Vector3(v2.x, 0, v2.y);
            rb.AddForce(newVector, ForceMode.Force);
        }
    }


}
