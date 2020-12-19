using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script which controls planet.
public class PlanetController : MonoBehaviour
{
    public float velocity; //Rotating velocty of planet
    public Planets planet; //Reference for data of planet

    void Update()
    {
        Rotationonpoint(velocity);
        GetComponent<MeshFilter>().mesh = planet.mesh;
        GetComponent<MeshRenderer>().material = planet.material;
        GetComponent<Transform>().localScale = new Vector3(planet.Scale, planet.Scale, planet.Scale);
    }

    //Function having rotation logic
    public void Rotationonpoint(float velocity)
    {
        transform.Rotate(Vector3.down,velocity*Time.deltaTime);
    }
   
  
}
