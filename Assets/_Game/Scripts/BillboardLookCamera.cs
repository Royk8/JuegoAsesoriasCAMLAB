using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BillboardLookCamera : MonoBehaviour
{
    private Camera _camera;
    public bool inputsActivados;
    public bool menuAbierto;
    private void Start()
    {
        _camera = Camera.main;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(0f, _camera.transform.rotation.eulerAngles.y, 0f);
    }

    private void Update()
    {
        if (Input.GetButton("Jump"))
        {
            ButtonJump();
        }
    }

    void ButtonJump()
    {
        if(!inputsActivados) return;
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetButton("PickUp"))
        {
            if (other is IRecogible)
            {
                (other as IRecogible).Recoger();
            }
        }
    }
}
