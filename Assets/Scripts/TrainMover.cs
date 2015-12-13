using UnityEngine;
using System.Collections;

public class TrainMover : MonoBehaviour
{
    public Vector3 movement;
    public int speed;
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("ControlMode") == "Autopilot")
        {
            movement = transform.position;
            movement.x += (speed * Time.deltaTime);
            transform.position = movement;

        }
    }
}