using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1_notifier : MonoBehaviour
{
    public delegate void message();
    public event message OnCylinderCollision;
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Cube") {
            OnCylinderCollision?.Invoke();
        }
    }
}
