using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D RB2D;
    public float maxSpeed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RB2D.velocity = Vector2.ClampMagnitude(RB2D.velocity, maxSpeed);
    }
}
