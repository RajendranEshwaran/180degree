using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundrySet : MonoBehaviour
{
    private Vector2 screenBounds;

    public GameObject left;
    public GameObject right;
    public GameObject top;
    public GameObject bottom;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));


        right.transform.position = new Vector2(screenBounds.x,0);
        left.transform.position = new Vector2(-screenBounds.x-.2f, 0);
        top.transform.position = new Vector2(0, screenBounds.y);
        bottom.transform.position = new Vector2(0, -screenBounds.y + 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
