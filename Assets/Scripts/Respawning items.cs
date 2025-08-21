using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Respawningitems : MonoBehaviour
{
    public float triangleObject = 0;
    public float SquareObject = 1;
    public float CircleObject = 2;
    public float spawnInterval = 3f;
    public GameObject[] preFabs;
    private float timer;


    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            int randomInt = Random.Range(0, 3);
            Instantiate(preFabs[randomInt], transform.position, transform.rotation);
            timer = 0f; // Reset the timer

        }
    }
}