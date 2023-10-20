using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej6_notifier : MonoBehaviour
{
    public delegate void message();
    public event message OnSphereCollision;
    public float speed;

    Rigidbody rb;
    void Start()
    {
        speed = 1;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || 
        Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) {
            if (!rb || rb.isKinematic) transform.Translate(Input.GetAxis("Horizontal2") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical2") * speed * Time.deltaTime);
            else rb.AddForce(Input.GetAxis("Horizontal2") * speed / 10, 0, Input.GetAxis("Vertical2") * speed / 10, ForceMode.VelocityChange);
        }
    }

    void OnTriggerEnter(Collider collider) {
        OnSphereCollision?.Invoke();
    }
}