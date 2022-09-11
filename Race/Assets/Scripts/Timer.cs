using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timeInSec;

    public float timer = 120;
    void Update()
    {
        if (timer > 0) { 
            timer -= Time.deltaTime;
            timeInSec.text = ((int)timer).ToString() + " сек";
        }

        if (timer < 0) {
            timer = 0;
            SceneManager.LoadScene(0);
        }
    }
}
