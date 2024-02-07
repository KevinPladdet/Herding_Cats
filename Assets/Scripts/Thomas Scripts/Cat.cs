using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public string name;
    public int rotation;

    int zRot;

    void Update()
    {
        if (!string.IsNullOrEmpty(name))
        {
            var color = name switch
            {
                "green" => new Color(0f, 1f, 0f),
                "yellow" => new Color(1f, 1f, 0f),
                "red" => new Color(1f, 0f, 0f),
                "blue" => new Color(0f, 0f, 1f),
                _ => new Color(0f, 0f, 0f),
            };

            this.gameObject.GetComponent<Renderer>().material.color = color;

            zRot = rotation switch
            {
                0 => 45,
                1 => 135,
                2 => 225,
                3 => 315,
                _ => 0,
            };

            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, zRot);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
