using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;
    float HorizonInput;
    float VertaicalInput;
    // Update is called once per frame
    void FixedUpdate()
    {
        HorizonInput = Input.GetAxis("Horizontal");
        VertaicalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * VertaicalInput);
        //transform.Translate(-Vector3.forward * Time.deltaTime * HorizonInput);
        transform.Rotate(Vector3.up * HorizonInput * speed * Time.deltaTime);
    }
}
