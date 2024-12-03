using UnityEngine;

public class GravitationForce : MonoBehaviour
{
      public float G;

      Rigidbody2D SaturnPhysics;
      Rigidbody2D PlutoPhysics;
      GameObject Pluto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Hämtar jor
        SaturnPhysics = GetComponent<Rigidbody2D>();
        Pluto = GameObject.Find("Pluto");
        //Hämtar månens fysikmotor
        PlutoPhysics = Pluto.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float r = Vector2.Distance(transform.position, Pluto.transform.position);

        float F = G*((PlutoPhysics.mass * SaturnPhysics.mass)/(r*r));

        //Vector2 Force = new Vector2(F,0);
        Vector2 Direction = transform.position - Pluto.transform.position;
        Direction.Normalize();

        Vector2 Force = Direction * F;



        PlutoPhysics.AddForce(Force);
    }
}
