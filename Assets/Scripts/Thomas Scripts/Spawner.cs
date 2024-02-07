using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float timeBetweenRounds;
    public GameObject catObject;
    public int maxCats = 10;

    void Start()
    {
        StartCoroutine(SpawnEnemies(timeBetweenRounds));
    }

    IEnumerator SpawnEnemies(float timer)
    {
        for(int i = 0; i < maxCats; i++)
        {
            GameObject cat = Instantiate(catObject, transform.position, Quaternion.identity);
            GetName(cat);
            int rnd = (UnityEngine.Random.Range(0, 3));
            cat.GetComponent<Cat>().rotation = rnd;
            yield return new WaitForSeconds(timer);
        }
    }

    void GetName(GameObject cat)
    {
        int rnd = (UnityEngine.Random.Range(0, 3));

        string name = rnd switch
        {
            0 => "green",
            1 => "yellow",
            2 => "red",
            3 => "blue",
            _ => "cat",
        };

        string objectName = rnd switch
        {
            0 => "GreenCat",
            1 => "YellowCat",
            2 => "RedCat",
            3 => "BlueCat",
            _ => "cat",
        };

        cat.GetComponent<Cat>().name = name;
        cat.name = objectName;
    }
}
