using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{
    public GameObject planet;
    public Transform spaceship;

    public int points;

    // Start is called before the first frame update
    void Start()
    {
        //Init Planets
        for(int i=0; i<Planet.numPlanets; i++)
        {
            Planet.creationDirection = (Planet.creationDirection + Planet.errorRatio * Random.insideUnitSphere).normalized;
            Planet.lastPlanetPos += Planet.planetDist * Planet.creationDirection;
            Instantiate(planet, Planet.lastPlanetPos, Quaternion.identity, null);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
