using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 10f;

    public float xRange = 20f;

    public GameObject projectilePrefab;
    
    private float horizontalInput;

    private void Update()
    {
        //deltaTime:diferencia de tiempo entre frames
       
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*speed*Time.deltaTime*horizontalInput);

        PlayerInBounds();
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FireProyectile();
        }
        
    }

    //void solo hace cosas no devuelve nada
    private void PlayerInBounds() 
    {
        Vector3 pos = transform.position;
        
        if(pos.x<-xRange)
        {
            transform.position =new Vector3(-xRange, pos.y, pos.z);
        }
    
        if(pos.x>xRange)
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);
        }
    
    }

    private void FireProyectile()
    {
        { 
          Instantiate(projectilePrefab, transform.position, Quaternion.identity); 
        }
    }








}
