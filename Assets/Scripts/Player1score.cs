using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1score : MonoBehaviour
{
    public float Player_1_Score = 0;
    public AudioSource soundeffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player 1 Scores")
        {
            Player_1_Score++;
            soundeffect.Play();
            Destroy(collision.gameObject);
        }

    }
}
