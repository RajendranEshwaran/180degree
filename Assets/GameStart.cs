using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{


    public Image background;

    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<Image>();

       // Doit();

        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
    }

    public void Doit()
    {
        background.color = GetRandomColor();
    }

    Color GetRandomColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }


    public void playBtn()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void statsBtn()
    {

    }
    public void creditBtn()
    {
        SceneManager.LoadScene("CreditScene");
    }
}
