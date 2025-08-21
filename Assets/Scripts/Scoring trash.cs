using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoringtrash : MonoBehaviour
{
    public float square = 0;
    public AudioSource soundeffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Square score")
        {
            square++;
            soundeffect.Play();
            Destroy(collision.gameObject);

        }

    }
}

