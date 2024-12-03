using System.Collections.Generic;
using UnityEngine;

public class GravityObject : MonoBehaviour
{
    [SerializeField] private float gravitationsKonstant = 0.1f;
    [SerializeField] private float _massa = 1f;
    [SerializeField] private Vector2 initialVelocity = new Vector2(10f, 0f);

    private static List<GravityObject> gravityObjects = new List<GravityObject>();
    private Rigidbody2D Rigidbody2D;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();

        
        Rigidbody2D.linearVelocity = initialVelocity;
    }

    void OnEnable()
    {
        gravityObjects.Add(this);
    }

    void OnDisable()
    {
        gravityObjects.Remove(this);
    }

    void FixedUpdate()
    {
        foreach (var annatObjekt in gravityObjects)
        {
            if (annatObjekt != this)
            {
                ApplyGravity(annatObjekt);
            }
        }
    }

    private void ApplyGravity(GravityObject annatObjekt)
    {
        Vector2 direction = annatObjekt.transform.position - transform.position;
        float distance = direction.magnitude;

        if (distance == 0) return;

        direction.Normalize();
        float forceMagnitude = gravitationsKonstant * (_massa * annatObjekt.massa) / (distance * distance);
        Vector2 gravityForce = direction * forceMagnitude;

        Rigidbody2D.AddForce(gravityForce);
    }

    public float massa
    {
        get { return _massa; }
        set { _massa = value; }
    }
}
