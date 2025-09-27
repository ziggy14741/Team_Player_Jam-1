using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2score : MonoBehaviour
{
    public float Player_2_Score = 0;
    public AudioSource soundeffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player 2 Scores")
        {
            Player_2_Score++;
            soundeffect.Play();
            Destroy(collision.gameObject);
        }

    }
}
