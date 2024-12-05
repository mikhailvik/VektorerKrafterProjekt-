
using UnityEngine;

public class GravityObject : MonoBehaviour
 {

public float G;

<<<<<<< HEAD
    // Lista över alla GravityObject-objekt i scenen
    public List<GravityObject> gravityObjects = new List<GravityObject>(); //Viktoriia Mikhailova bytat public List
=======
Rigidbody2D SaturnPhysics;
Rigidbody2D PlutoPhysics;
GameObject Pluto;
>>>>>>> 42fa3a26fe9fb74dcfa5ddc8cd2e05b2e5aa18e9

 void Start()
 {
    // saturn fysikmotor
    SaturnPhysics = GetComponent<Rigidbody2D>();
    Pluto = GameObject.Find("Pluto");

    //Pluto fysikmotor
    PlutoPhysics = Pluto.GetComponent<Rigidbody2D>(); 
 }

 void Update()
 {
    float r = Vector2.Distance(transform.position, Pluto.transform.position);

    float F = G*((PlutoPhysics.mass * SaturnPhysics.mass)/(r*r));

   
    Vector2 Direction = transform.position - Pluto.transform.position ;
    Direction.Normalize();

    Vector2 Force = Direction * F;


    PlutoPhysics.AddForce(Force);
 }
 }