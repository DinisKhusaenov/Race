using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public void Dead()
    {
        SceneManager.LoadScene(0);
        AudioListener.volume = 1f;
    }
   
}
