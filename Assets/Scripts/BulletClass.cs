using UnityEngine;

public class BulletClass : MonoBehaviour
{

    int bulletSpd;
    Vector2 moveDirection;

    public BulletClass()
    {
        bulletSpd = 1;
        moveDirection.x = Input.mousePosition.x;
        moveDirection.y = Input.mousePosition.y;
        
    }

    public void Update()
    {
        Vector2 pos = transform.position;
        pos += moveDirection * bulletSpd;
        this.transform.position = pos;

    }

}
