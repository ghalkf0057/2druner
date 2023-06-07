using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundspawners : MonoBehaviour
{
    [SerializeField] private GameObject templatePlatforms;

    private GameObject spawnPlatforms;

    private void Start()
    {
      InvokeRepeating ("Platforms", 1, 2.5f); //спавн платформ
    }

    private void Platforms()
    {
      spawnPlatforms = Instantiate(templatePlatforms, transform.position, Quaternion.identity) as GameObject;
    }
  
}


