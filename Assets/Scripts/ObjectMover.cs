using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public float timer = 0.0f;
    public float directionChangeDelay = 2.0f;
    public Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > directionChangeDelay)
        {
            movement *= -1.0f;
            timer = 0.0f;

        }
        transform.position += Time.deltaTime * movement;
    }

}
