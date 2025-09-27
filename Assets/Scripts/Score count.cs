using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class Scorecount : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public float final_value;
    public Scoringblue triangle;
    public Scoringgreen circle;
    public Scoringtrash square;
    public PlayerTags collision;
    public void finalscore()
    {
        Debug.Log(triangle.triangle + " "+ circle.circle + " " + square.square);
        final_value = triangle.triangle + circle.circle + square.square;
        PlayerPrefs.SetFloat("FinalScore", final_value);

        if (collision.GetComponent<PlayerTags>().mode == 2)
        {
            P2++;
        }
        if (collision.GetComponent<PlayerTags>().mode == 1)
        {
            P1++;
        }
    }

    public void Start()
    {
        if (scoreText != null)
        {
            Debug.Log("A");
            scoreText.text = PlayerPrefs.GetFloat("FinalScore").ToString();
        }
    }

}