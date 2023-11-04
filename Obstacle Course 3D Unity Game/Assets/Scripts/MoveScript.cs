using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;

    int score = 0;

    void Start()
    {
        PrintIntruction();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintIntruction()
    {
        Debug.Log("Welcome, move your blue square player with ADSW, or Arrow Keys.");
        Debug.Log("Try not to collide with anything!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }

    void OnCollisionEnter()
    {
        score--;
        Debug.Log("Score: " + score);
    }
}
