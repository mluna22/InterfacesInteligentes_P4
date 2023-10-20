using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ej6_observer : MonoBehaviour
{
    ej6_notifier detectTrigger;
    TextMeshProUGUI text;
    public int score;
    void Start()
    {
        score = 0;
        text = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();
        text.text = "Score: " + score;
        detectTrigger = GameObject.Find("Sphere").GetComponent<ej6_notifier>();
        detectTrigger.OnSphereCollision += AddPoints;
        detectTrigger.OnSphereCollision += MoveRandom;
    }

    void AddPoints() {
        score += 1;
        text.text = "Score: " + score;
    }

    void MoveRandom() {
        gameObject.transform.position = new Vector3(Random.Range(-14f,14f),0.5f,Random.Range(-9f,9f));
    }
}
