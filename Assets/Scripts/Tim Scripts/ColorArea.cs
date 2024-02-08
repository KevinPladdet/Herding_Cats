using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorArea : MonoBehaviour
{
    [SerializeField] private String colorOfArea;

    private void OnTriggerEnter2D(Collider2D cat)
    {
        // Check objects paret name 
        if (cat.name.Contains(colorOfArea))
        {
            TheRightCat(cat);
        }
        else
        {
            TheWrongCat();
        }
    }

    private void TheRightCat(Collider2D cat)
    {
        Debug.Log("this is " + colorOfArea + " cat");
        DeleteCatObject(cat);
    }

    private void TheWrongCat()
    {
        Debug.Log("not the right cat");
    }

    //If you want to delete object
    private void DeleteCatObject(Collider2D cat)
    {
        Destroy(cat.gameObject);
    }

    //If you want to disable object
    private void DisableCatObject(Collider2D cat)
    {
        cat.gameObject.SetActive(false);
    }
}
