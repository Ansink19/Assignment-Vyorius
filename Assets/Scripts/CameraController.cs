using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    [SerializeField]
    private Vector3 offSet;

    [SerializeField]
    private float rotationSpeed;

    private Vector3 currentVelocity;

    public float smoothTime;

    private void Update()
    {
        offSet = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up) * offSet;
        transform.position = Vector3.SmoothDamp(transform.position, player.position + offSet , ref currentVelocity ,smoothTime);

        transform.LookAt(player.position);
    }

}
