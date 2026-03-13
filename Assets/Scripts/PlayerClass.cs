using JetBrains.Annotations;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{

    int score;
    public GameObject Bullet;

    public PlayerClass()
    {
   
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
            GameObject bullet = Instantiate(Bullet);
        }

    }

}
