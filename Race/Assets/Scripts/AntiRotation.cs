using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiRotation : MonoBehaviour
{
    public Collider car;

    private void Update()
    {
        if(car.transform.rotation.y > 0)
        {
            car.transform.Rotate(0, -90, 0);
        } 

        if (car.transform.rotation.y < -180 )
        {
            Debug.Log("Rotate");
            car.transform.Rotate(0, -90, 0);
        }
    }
}