using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ej5 : MonoBehaviour
{
    public int points;
    TextMeshProUGUI text;
    void Start() {
        points = 0;
        text = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();
        text.text = "Points: " + points;
    }

    void OnCollisionEnter(Collision collision) {
        string group = collision.gameObject.tag;
        if (group == "group1") points += 5;
        if (group == "group2") points += 10;
        if (group == "group1" || group == "group2") {
            Destroy(collision.gameObject);
            text.text = "Points: " + points;
        }
    }
}
