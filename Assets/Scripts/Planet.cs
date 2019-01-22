using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public Master master;

    public const float planetDist = 1000;
    public const float errorRatio = 0.1f;
    public const int numPlanets = 10;
    public const float destroyDistance = 1000;

    public static Vector3 lastPlanetPos = Vector3.zero;

    public static Vector3 creationDirection = Vector3.forward;

    public static float atmoMult = 1.1f;
    float radius;

    private Vector3 direction;
    
    void Start()
    {
        radius = 150 + 250 * Random.value;
        transform.localScale = new Vector3(radius, radius, radius);
        direction = creationDirection;

        master = FindObjectOfType<Master>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Dot(Spaceship.spaceship.position - transform.position, direction) > destroyDistance)
        {
            creationDirection = (creationDirection + errorRatio * Random.insideUnitSphere).normalized;
            lastPlanetPos += planetDist * creationDirection;
            Instantiate(master.planet, lastPlanetPos, Quaternion.identity, null);
            Destroy(gameObject);
        }
        if (Vector3.Distance(Spaceship.spaceship.position, transform.position) <= atmoMult * radius)
        {
            print("hit");
        }
    }

    void GetHit()
    {

    }
}
