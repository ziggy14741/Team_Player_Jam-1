using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scoringblue : MonoBehaviour
{public float triangle = 0;
    public AudioSource soundeffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Triangle Score")
        {
            triangle++;
            soundeffect.Play();
            Destroy(collision.gameObject);

        }
    }
} 
   
    