using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float turnSpeed;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate
        transform.RotateAround(Vector3.up, turnSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.RotateAround(transform.right, turnSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

        // Move
        transform.position += moveSpeed * Time.deltaTime * transform.forward;
    }
}
