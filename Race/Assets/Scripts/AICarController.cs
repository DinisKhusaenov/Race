using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarController : MonoBehaviour
{

    private float speed = 1500f;
    private Rigidbody car;

    void Start()
    {
        car = GetComponent<Rigidbody>();
    }

    void Update()
    {
        car.AddForce(new Vector3(speed, 0, 0));
    }
    
    public void DeleteCar()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Barrier"))
        {
            Debug.Log("Destroy");
            DeleteCar();
        }
    }
}
