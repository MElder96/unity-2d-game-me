using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawner : MonoBehaviour
{
    public GameObject cratePrefab;

    public int amountOfCratesToSpawn;

    private void Start()
    {
        //declare it an int setting it at 0, as long as i is less than keep wokring, add number by 1
        for (int i = 0; i < amountOfCratesToSpawn; i ++)
        {
            //object to copy, position of create spawner location, rotation current, parent = crateSpawner
            Instantiate(cratePrefab, transform.localPosition, Quaternion.identity, this.transform);
        }
    }
}
