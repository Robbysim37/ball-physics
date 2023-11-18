using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public Rigidbody2D rig;

    public float moveForce;
    public float maxVelocityX;

    // Update is called once per frame
    void Update(){

        if (Input.GetKey(KeyCode.A)) {
            rig.AddForce(Vector2.left * moveForce);
        }

        if (Input.GetKey(KeyCode.D)) {
            rig.AddForce(Vector2.right * moveForce);
        }

        if (Mathf.Abs(rig.velocity.x) > maxVelocityX) {
            rig.velocity = new Vector2(Mathf.Sign(rig.velocity.x) * maxVelocityX, rig.velocity.y);
        }
    }
}
