using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderTrigger : MonoBehaviour
{

    public GameObject PS;
    public GameObject Spawner;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Cat")
        {
            Spawner.GetComponent<Spawner>().currentAmount -= 1;
            PS.GetComponent<PlayerStats>().TakeDamage(1);
            Destroy(other.gameObject);
        }  
    }

}
