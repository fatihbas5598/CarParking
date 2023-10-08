using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelsControl : MonoBehaviour
{
    [SerializeField] Transform[] _wheels;
    private Vector3 _angle;
    private float _input;
    [SerializeField] float _steeringWheelsLimit;

    private void Update()
    {
        SteeringInput();
        RotateWheels();
    }

    private void SteeringInput()
    {
        _input = -Input.GetAxis("Horizontal") * _steeringWheelsLimit;
    }

    private void RotateWheels()
    {
        _angle = _wheels[0].localEulerAngles;
        _angle = _wheels[1].localEulerAngles;
        _angle.z = _input;
        _wheels[0].localEulerAngles = _angle;
        _wheels[1].localEulerAngles = _angle;
    }
}
