using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1_observer : MonoBehaviour
{
    float speed;
    GameObject cylinder;
    ej1_notifier detectCollision;
    void Start()
    {
        speed = 0f;
        cylinder = GameObject.Find("Cylinder");
        detectCollision = cylinder.GetComponent<ej1_notifier>();
        if (gameObject.tag == "group1") detectCollision.OnCylinderCollision += ChangeColor;
        if (gameObject.tag == "group2") detectCollision.OnCylinderCollision += IncreaseSpeed;
    }

    void FixedUpdate()
    {
        Vector3 direction = cylinder.transform.position - gameObject.transform.position;
        gameObject.GetComponent<Rigidbody>().AddForce(direction.normalized * speed * Time.deltaTime, ForceMode.Impulse);
    }

    void IncreaseSpeed() {
        speed = 5f;
    }

    void ChangeColor() {
        Material mat = gameObject.GetComponent<Renderer>().material;
        mat.color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0.3f,1f));
    }
}
