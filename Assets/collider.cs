using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class collider : MonoBehaviour
{

    public ParticleSystem par;
    public AudioSource source;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name != "2x")
        {
            Debug.Log("Collision With Player and Objects");
            par.transform.position = transform.position;
            par.Play();
            source.Play();
        }

         StartCoroutine(gameOver());

    }




    IEnumerator gameOver()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            if (this.gameObject != null)
            {
                Destroy(this.gameObject);

            }
            SceneManager.LoadScene("GameStart");
        }
    }

}
