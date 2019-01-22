using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public static List<GameObject> planets = new List<GameObject>();
    public static float planetDist = 1000;
    public static float errorRatio = 0.1f;
    public static int numPlanets = 10;

    public static Vector3 lastPlanetPos = Vector3.zero;

    public static Vector3 creationDirection = Vector3.forward;

    public static float hitMult;
    float radius;
    bool hitYet = false;
    
    void Start()
    {
        radius = 150 + 250 * Random.value;
        transform.localScale = new Vector3(radius, radius, radius);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Spaceship.spaceship.position, transform.position) <= hitMult * radius)
        {

        }
    }

    void GetHit()
    {

    }
}
