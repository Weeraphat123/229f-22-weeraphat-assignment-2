using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public Rigidbody rb;
    public float enginePowerThrust, liftBooster, drag, angularDrag;

    void FixedUpdate()
    {
        //1.Add Thrust
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * enginePowerThrust);
        }
        //2.lift
        Vector3 lift = Vector3.Project(rb.velocity, transform.forward);
        rb.AddForce(transform.up * lift.magnitude * liftBooster);

        //3.Drag
        rb.drag = rb.velocity.magnitude * drag;
        rb.angularDrag = rb.velocity.magnitude * angularDrag;

        //4.Left - Right
        rb.AddTorque(Input.GetAxis("Horizontal") * transform.forward * -1);
        //4.Up-Down
        rb.AddTorque(Input.GetAxis("Vertical") * transform.right);

    }

}
