using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoringgreen : MonoBehaviour
{
        public float circle = 0;
    public AudioSource soundeffect;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Circle Score")
            {
                circle++;
                soundeffect.Play();
                Destroy(collision.gameObject);

            }

        }
    }


