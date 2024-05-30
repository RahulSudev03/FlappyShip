using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{

    public int moveSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < -20)
        {
            Destroy(gameObject);
        }

    }
}
