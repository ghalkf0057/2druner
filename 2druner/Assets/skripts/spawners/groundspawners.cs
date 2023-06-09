using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawners : MonoBehaviour
{
    [SerializeField] private GameObject[] templatePlatforms; //Переписать

    private void Start()
    {
      InvokeRepeating ("Platforms", 1, 2.5f); //спавн платформ
    }

    private void Platforms()
    {
      Instantiate(templatePlatforms[Random.Range(0, templatePlatforms.Length)], transform.position, Quaternion.identity); // переписать
    }
}
