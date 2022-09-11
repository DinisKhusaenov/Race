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
        record.text = "������: " + PlayerPrefs.GetInt("Score").ToString();
        scoreInDeath.text = "�� �������: " + ((int)(-car.position.x / 2)).ToString();
    }
    private void Update()
    {
        if (car.position.x > 0)
        {
            scoreText.text = "����: 0";
        }
        else
        {
            scoreText.text = "����: " + ((int)(-car.position.x / 2)).ToString();
            scoreInDeath.text = "�� �������: " + ((int)(-car.position.x / 2)).ToString();
        }

        if ((int)(-car.position.x / 2) > finalScore)
        {
            finalScore = (int)(-car.position.x / 2);
            PlayerPrefs.SetInt("Score", finalScore);
            record.text = "������: " + PlayerPrefs.GetInt("Score").ToString();
        }
    }

}
