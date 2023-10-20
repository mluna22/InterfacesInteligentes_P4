using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej4 : MonoBehaviour
{
    public int points;
    void Start() {
        points = 0;
    }

    void OnCollisionEnter(Collision collision) {
        string group = collision.gameObject.tag;
        if (group == "group1") points += 5;
        if (group == "group2") points += 10;
        if (group == "group1" || group == "group2") {
            Destroy(collision.gameObject);
            Debug.Log("points: " + points);
        }
    }
}
