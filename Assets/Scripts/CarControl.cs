using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    Rigidbody2D _rb;

    [SerializeField] AnimateWheels _animateWheels;
    [SerializeField] float _carSpeed;
    [SerializeField] float _steeringSpeed;
    private float _minSpeed = 10f;
    float _maxSpeed = 30f;

    float _verticalInput;
    float _horizontalInput;
    float _direction;
    private float _animateWheelsValue = 0.1f;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        CarMovement();
    }

    private void CarMovement()
    {
        _verticalInput = Input.GetAxis("Vertical") * _carSpeed;
        _horizontalInput = -Input.GetAxis("Horizontal") * _steeringSpeed;

        if (_verticalInput < -1) _carSpeed = _minSpeed;
        else _carSpeed = _maxSpeed;

        _animateWheels.MoveWheels(-_verticalInput * _animateWheelsValue);
        _direction = Mathf.Sign(Vector2.Dot(_rb.velocity, _rb.GetRelativeVector(Vector2.right)));
        _rb.rotation += _horizontalInput * _direction * _rb.velocity.magnitude;
        _rb.AddRelativeForce(_verticalInput * Vector2.right);
    }
}