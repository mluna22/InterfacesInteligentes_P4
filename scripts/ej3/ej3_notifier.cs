using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3_notifier : MonoBehaviour
{
    public delegate void message();
    public event message OnCubeApproach;

    public float range;
    GameObject cube;
    bool approached = true;
    void Start()
    {
        range = 3;
        cube = GameObject.Find("Cube");
    }

    void Update()
    {
        if(Vector3.Distance(gameObject.transform.position, cube.transform.position) < range) {
            if (approached) OnCubeApproach?.Invoke();
            approached = false;
        } else approached = true;
    }
}
