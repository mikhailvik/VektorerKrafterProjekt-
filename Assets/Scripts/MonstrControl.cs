using UnityEngine;

public class MonstrControl : MonoBehaviour
{
    Vector2 Speed;
    GameObject ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Initialiserar vektorn Speed (default är 0 i x-led och 0  i y-led )
       Speed = new Vector2(0, 0);
       ball = GameObject.Find("ball");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Speed * Time.deltaTime);
        KeyboardControl();  

        Debug.Log("Avstånd till : "  + Vector2.Distance(transform.position, ball.transform.position));
    }


    void KeyboardControl()
    {
        if(Input.GetKey(KeyCode.RightArrow) == true)
        {
            Speed.x = 1;
        }

        else if(Input.GetKey(KeyCode.LeftArrow) == true)
        {
            Speed.x = -1;
        }

        else if(Input.GetKey(KeyCode.UpArrow) == true)
        {
            Speed.y = 1;
        }

         else if(Input.GetKey(KeyCode.DownArrow) == true)
        {
            Speed.y = -1;
        }

        else
        {
            Speed.x = 0;
            Speed.y = 0;   
        }
    }
}
