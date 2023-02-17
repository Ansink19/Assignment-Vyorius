using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float steeringAngle;

    private Rigidbody rigidbody;

    private float right;
    private float forward;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        right = Input.GetAxisRaw("Right");
        forward = Input.GetAxisRaw("Forward");

        if(forward > 0.1f || forward < -0.1f)
        {
            transform.Rotate(new Vector3(0, right * Time.deltaTime, 0) * steeringAngle);
        }
        
        rigidbody.velocity = transform.forward * speed * forward;
    }
}
