using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform car;

    private Vector3 offset = new Vector3(0f, 2f, -4f);
    private float speed = 10f;

    private void FixedUpdate()
    {
        var targetPosition = car.TransformPoint(offset);
        transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);

        var direction = car.position - transform.position;
        var rotation = Quaternion.LookRotation(direction, Vector3.up);

        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);
    }
}
