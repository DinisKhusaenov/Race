using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCar : MonoBehaviour
{

    public GameObject deathScreen;

    private void Start()
    {
        deathScreen.SetActive(false);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Barrier"))
        {
            if (!deathScreen.activeSelf)
            {
                deathScreen.SetActive(true);
                Time.timeScale = 0f;
                AudioListener.volume = 0f;
            }         
        }
        if (other.gameObject.CompareTag("CarAI"))
        {
            if (!deathScreen.activeSelf)
            {
                deathScreen.SetActive(true);
                Time.timeScale = 0f;
                AudioListener.volume = 0f;
            }
        }
    }
}
