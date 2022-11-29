using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float upperLimit = 20f;

    public float lowerLimit = -10f;


    private void Update()
    {
        // LIMITE INFERIOR -> ANIMALES NO ALIMENTADOS

        if(transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
        
        Debug.Log ("GAME OVER");
            Time.timeScale = 0;
        }

       else if(transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }

    }




}
