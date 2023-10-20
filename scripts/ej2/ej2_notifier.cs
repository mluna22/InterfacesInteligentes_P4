using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej2_notifier : MonoBehaviour
{
    public delegate void message();
    public event message OnCubeCollision;
    public event message OnCubeCollision1;
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "group1") OnCubeCollision1?.Invoke();
        else if (collision.gameObject.tag != "environment") OnCubeCollision?.Invoke();
    }
}
