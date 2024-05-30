using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScrpit logic1;

    // Start is called before the first frame update
    void Start()
    {
        logic1 = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScrpit>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic1.addScore(1);
        }
    }

}
