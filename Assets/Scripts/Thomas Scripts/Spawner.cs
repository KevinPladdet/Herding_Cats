using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float timeBetweenRounds;
    public GameObject greenCat;
    public GameObject yellowCat;
    public GameObject blueCat;
    public GameObject redCat;
    public int maxCats = 10;

    void Start()
    {
        StartCoroutine(SpawnEnemies(timeBetweenRounds));
    }

    IEnumerator SpawnEnemies(float timer)
    {
        for (int i = 0; i < maxCats; i++)
        {
            int rndCat = (UnityEngine.Random.Range(0, 3));
            GameObject catObject = null;
            switch (rndCat)
            {
                case 0:
                    catObject = greenCat; break;
                case 1:
                    catObject = yellowCat; break;
                case 2:
                    catObject = redCat; break;
                case 3:
                    catObject = blueCat; break;
            }
            GameObject cat = Instantiate(catObject, transform.position, Quaternion.identity);

            int rnd = (UnityEngine.Random.Range(0, 3));
            int rotation = rnd switch
            {
                0 => 45,
                1 => 135,
                2 => 225,
                3 => 315,
                _ => 0,
            };

            cat.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, rotation);
            yield return new WaitForSeconds(timer);
        }
    }
    /*
    void GetNewCat(GameObject cat)
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
    }*/
}
