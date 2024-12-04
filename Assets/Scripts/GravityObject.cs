
using UnityEngine;

public class GravityObject : MonoBehaviour
 {

public float G;

Rigidbody2D SaturnPhysics;
Rigidbody2D PlutoPhysics;
GameObject Pluto;

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