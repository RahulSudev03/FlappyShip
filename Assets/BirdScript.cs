using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    //Rigid body that references the bird game object
    public Rigidbody2D myRigidbody;

    //Strength of each flap done by the bird, what will give velocity in upwards direction.
    public float flapStrength;

    public LogicScrpit logic;

    public bool isAlive;

    public bool isGameOverPlayed;

    public AudioManager audioManager;


    // Start is called before the first frame update

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScrpit>();

        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();

        isAlive = true;

        isGameOverPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && isAlive)
        {

            myRigidbody.velocity = Vector2.up * flapStrength;

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isGameOverPlayed == false)
        {
            audioManager.PlaySFX(audioManager.gameOver);
            isGameOverPlayed = true;
        }
        audioManager.Stop();
        audioManager.PlaySFX(audioManager.death);
        isAlive = false;
        logic.gameOver();
    }

}
