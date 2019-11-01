using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    

    private void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

       
        if (collision.gameObject.name == "2x")
        {
            Debug.Log("Collision With Player and 2x");
            Destroy(collision.gameObject);
        }

        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        


    }


}
