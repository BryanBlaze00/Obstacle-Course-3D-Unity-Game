using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Dropper : MonoBehaviour
{
    MeshRenderer mesh;
    Rigidbody rb;
    [SerializeField] float timeToWait = 5f;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        mesh.enabled = false;
    }
    void Update()
    {
        if (Time.time > timeToWait)
        {
            mesh.enabled = true;
            rb.useGravity = true;
        }
    }
}
