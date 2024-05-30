using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject pipe;
    public double spawnRate = 3;

    public float pipePosition = 5;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawn();
            timer = 0;
        }
    }

    void spawn()
    {
        float highValy = transform.position.y + pipePosition;
        float lowValy = transform.position.y - pipePosition;

        float highValx = transform.position.x + pipePosition;
        float lowValx = transform.position.x - pipePosition;
        Instantiate(pipe, new Vector3(Random.Range(lowValx, highValx), Random.Range(lowValy, highValy), 0), transform.rotation);
    }
}
