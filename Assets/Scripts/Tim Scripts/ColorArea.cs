using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorArea : MonoBehaviour
{
    [SerializeField] private String colorOfArea;

    private void OnCollisionEnter2D(Collision2D cat)
    {
        // Check objects paret name 
        if (cat.transform.parent.gameObject.name.Contains(colorOfArea))
        {
            TheRightCat(cat);
        }
        else
        {
            TheWrongCat();
        }
    }

    private void TheRightCat(Collision2D cat)
    {
        Debug.Log("this is " + colorOfArea + " cat");
        DeleteCatObject(cat);
    }

    private void TheWrongCat()
    {
        Debug.Log("not the right cat");
    }

    //If you want to delete object
    private void DeleteCatObject(Collision2D cat)
    {
        Destroy(cat.gameObject);
    }

    //If you want to disable object
    private void DisableCatObject(Collision2D cat)
    {
        cat.gameObject.SetActive(false);
    }
}
