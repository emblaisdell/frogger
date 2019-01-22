using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    public static Transform spaceship;
    public float turnSpeed;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        spaceship = transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate
        transform.Rotate(transform.up, turnSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.Rotate(transform.right, turnSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

        // Move
        transform.position += moveSpeed * Time.deltaTime * transform.forward;
    }
}
