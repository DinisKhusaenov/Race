using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] public Transform car;
    [SerializeField] public Text scoreText;
    private int finalScore;
    [SerializeField] public Text record;
    [SerializeField] public Text scoreInDeath;

    private void Start()
    {
        finalScore = PlayerPrefs.GetInt("Score");
        record.text = "Рекорд: " + PlayerPrefs.GetInt("Score").ToString();
        scoreInDeath.text = "Вы набрали: " + ((int)(-car.position.x / 2)).ToString();
    }
    private void Update()
    {
        if (car.position.x > 0)
        {
            scoreText.text = "Счёт: 0";
        }
        else
        {
            scoreText.text = "Счет: " + ((int)(-car.position.x / 2)).ToString();
            scoreInDeath.text = "Вы набрали: " + ((int)(-car.position.x / 2)).ToString();
        }

        if ((int)(-car.position.x / 2) > finalScore)
        {
            finalScore = (int)(-car.position.x / 2);
            PlayerPrefs.SetInt("Score", finalScore);
            record.text = "Рекорд: " + PlayerPrefs.GetInt("Score").ToString();
        }
    }

}
