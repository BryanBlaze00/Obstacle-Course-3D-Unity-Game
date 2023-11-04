using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float yRotate = 1f;

    void Start()
    {

    }
    void Update()
    {
        transform.Rotate(0, yRotate, 0);
    }
}
