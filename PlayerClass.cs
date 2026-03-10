using JetBrains.Annotations;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{

    int lives;
    int score;

    public PlayerClass()
    {
        this.lives = 5;
        this.score = 0;
    }


    void Update()
    {

        //point player to cursor (WORKS)
        Vector2 direction = (Vector2)Input.mousePosition - new Vector2(Screen.width / 2, Screen.height / 2);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(0, 0, angle);


        //detect mouse click to shoot
        if (Input.GetMouseButtonDown(0))
        {
            //create bullet here 
        }

    }

}
