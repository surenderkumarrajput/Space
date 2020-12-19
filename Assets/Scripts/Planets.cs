using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Scriptable object that contains the data for planet
[CreateAssetMenu(fileName ="new Planet",menuName ="SS.Bodies")]
public class Planets : ScriptableObject
{
    public string planetName;
    public string planetPlace;
    public Material material;
    public string Mass;
    public string Size;
    public float Scale;
    public Mesh mesh;
    public float OrbitalVelocity;
    public string NumberofMoons;
    public string Conclusion;
}
