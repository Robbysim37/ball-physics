using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformPhysics : MonoBehaviour
{
    public float bounceForce;
    private void OnCollisionEnter2D(Collision2D collision) {
        Rigidbody2D rig = collision.rigidbody;

        rig.AddForce(Vector2.up * bounceForce);
    }
}
