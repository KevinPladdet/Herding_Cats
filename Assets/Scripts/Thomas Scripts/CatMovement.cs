using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }
}
