using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public GameObject Enemy;
    public double spawnRate = 4;

    public float enemyPosition = 5;

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
        float highValy = transform.position.y + enemyPosition;
        float lowValy = transform.position.y - enemyPosition;

        float highValx = transform.position.x + enemyPosition;
        float lowValx = transform.position.x - enemyPosition;
        Instantiate(Enemy, new Vector3(Random.Range(lowValx, highValx), Random.Range(lowValy, highValy), 0), transform.rotation);
    }
}
