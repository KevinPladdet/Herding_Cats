using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollorArea : MonoBehaviour
{
    [SerializeField] private String collorOfArea;

    private void OnCollisionEnter(Collision cat)
    {
        // Check object name
        if (cat.transform.name.Contains(collorOfArea))
        {
            DeletCatObject(cat);
            //DisableCatObject(cat);
        }
        else
        {
            TheWrongCat();
        }

        // Check objects script variable name 
        if (cat.transform.GetComponent<CatScript>().catCollarName == collorOfArea)
        {
            TheRightCat(cat);
        }
        else
        {
            TheWrongCat();
        }

        // Check objects paret name 
        if (cat.transform.parent.gameObject.name.Contains(collorOfArea))
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
        Debug.Log("this is " + collorOfArea + " cat");
        DeletCatObject(cat);
    }

    private void TheWrongCat()
    {
        Debug.Log("not the right cat");
    }

    //If you want to delet object
    private void DeletCatObject(Collision cat)
    {
        Destroy(cat.gameObject);
    }

    //If you want to disable object
    private void DisableCatObject(Collision cat)
    {
        cat.gameObject.SetActive(false);
    }
}
