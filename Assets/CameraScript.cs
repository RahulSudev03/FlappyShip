using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Initial camera speed
    public float cameraSpeed = 2.0f;

    // Speed increase rate per second
    public float speedIncreaseRate = 0.1f;

    // Private variable to keep track of time elapsed
    private float timeElapsed = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // Update the time elapsed
        timeElapsed += Time.deltaTime;

        // Increase the camera speed over time
        cameraSpeed += speedIncreaseRate * Time.deltaTime;

        // Move the camera forward
        transform.position += Vector3.right * cameraSpeed * Time.deltaTime;
    }
}

