using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorArea : MonoBehaviour
{
    [SerializeField] private String colorOfArea;

    public GameObject SM;
    public GameObject PS;
    public GameObject Spawner;

    private void OnTriggerEnter2D(Collider2D cat)
    {
        // Check objects paret name 
        if (cat.name.Contains(colorOfArea))
        {
            TheRightCat(cat);
        }
        else
        {
            TheWrongCat(cat);
        }
    }

    private void TheRightCat(Collider2D cat)
    {
        SM.GetComponent<ScoreScript>().AddScore();
        DeleteCatObject(cat);
    }

    private void TheWrongCat(Collider2D cat)
    {
        PS.GetComponent<PlayerStats>().TakeDamage(1);
        DeleteCatObject(cat);
    }

    //If you want to delete object
    private void DeleteCatObject(Collider2D cat)
    {
        Spawner.GetComponent<Spawner>().currentAmount -= 1;
        Destroy(cat.gameObject);
    }

    //If you want to disable object
    private void DisableCatObject(Collider2D cat)
    {
        cat.gameObject.SetActive(false);
    }
}
