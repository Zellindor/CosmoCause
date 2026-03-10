using UnityEngine;

public class BulletClass : MonoBehaviour
{
    //this entire bullet class may or may not work
    int bulletSpd;
    Vector2 moveDirection;

    //constructor
    private void Start()
    {
        bulletSpd = 1;
        moveDirection.x = Input.mousePosition.x;
        moveDirection.y = Input.mousePosition.y;
    }

    public void Update()
    {

        //every frame make the bullet travel in the direction of moveDirection
        Vector2 pos = transform.position;
        pos += moveDirection * bulletSpd;
        this.transform.position = pos;

    }

}
