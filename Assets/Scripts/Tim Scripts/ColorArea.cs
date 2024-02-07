using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorArea : MonoBehaviour
{
    [SerializeField] private String colorOfArea;

    private void OnCollisionEnter(Collision cat)
    {
        // Check object name
        if (cat.transform.name.Contains(colorOfArea))
        {
            DeleteCatObject(cat);
            //DisableCatObject(cat);
        }
        else
        {
            TheWrongCat();
        }

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

    private void TheRightCat(Collision cat)
    {
        Debug.Log("this is " + colorOfArea + " cat");
        DeleteCatObject(cat);
    }

    private void TheWrongCat()
    {
        Debug.Log("not the right cat");
    }

    //If you want to delet object
    private void DeleteCatObject(Collision cat)
    {
        Destroy(cat.gameObject);
    }

    //If you want to disable object
    private void DisableCatObject(Collision cat)
    {
        cat.gameObject.SetActive(false);
    }
}
