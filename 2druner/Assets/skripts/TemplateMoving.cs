using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateMoving : MonoBehaviour
{
    [SerializeField] private float TemplateSpeed = 5f; //

    //{SerializeField} - 
    // float - 
    //speed - 


    //
    private void Update()
    {
      transform.position -= new Vector3 (TemplateSpeed * Time.deltaTime, 0, 0); 
      //
    }
}