using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float _steerSpeed = 0.1f;
    [SerializeField] float _speed = 20f;
    [SerializeField] float _speedUp = 30f;
    [SerializeField] float _speedDown = 15;

    void Update()
    {
        Move();
    }

    void Move()
    {
        float _steerDir = Input.GetAxis("Horizontal") * _steerSpeed * Time.deltaTime;
        float _moveVel = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        transform.Rotate(0, 0, -_steerDir);
        transform.Translate(0, _moveVel, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "SpeedUp")
        {
            _speed = _speedUp;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag != "SpeedUp")
        {
            _speed = _speedDown;
        }    
    }
}
