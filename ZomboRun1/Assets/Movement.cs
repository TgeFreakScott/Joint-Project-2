using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{

    // public GameObject ground;
    private Vector3 spawnPoint;

    // Use this for initialization
    void Start()
    {

        spawnPoint = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.acceleration.x, 0);

        transform.position = transform.position + Camera.main.transform.forward * 3.5f * Time.deltaTime;
        
        if (transform.position.y < -10)
        {
            transform.position = spawnPoint;
        }

    }

}
