using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej2_observer : MonoBehaviour
{
    float speed;
    GameObject cylinder;
    ej2_notifier detectCollision;
    void Start()
    {
        speed = 0f;
        cylinder = GameObject.Find("Cylinder");
        GameObject cube = GameObject.Find("Cube");
        detectCollision = cube.GetComponent<ej2_notifier>();
        if (gameObject.tag == "group1") detectCollision.OnCubeCollision += IncreaseSpeed;
        if (gameObject.tag == "group2") detectCollision.OnCubeCollision1 += IncreaseSize;
    }

    void FixedUpdate()
    {
        Vector3 direction = cylinder.transform.position - gameObject.transform.position;
        gameObject.GetComponent<Rigidbody>().AddForce(direction.normalized * speed * Time.deltaTime, ForceMode.Impulse);
    }

    void IncreaseSpeed() {
        speed = 5f;
    }

    void IncreaseSize() {
        gameObject.transform.localScale += new Vector3(1,1,1);
    }
}
