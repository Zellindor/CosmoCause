using UnityEngine;

public class BulletClass : MonoBehaviour
{
    float bulletSpd;
    Vector2 moveDirection;

    private void Start()
    {
        bulletSpd = 10f;
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorld.z = 0;
        moveDirection = (mouseWorld - Vector3.zero).normalized;
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        transform.position += (Vector3)(moveDirection * bulletSpd * Time.deltaTime);
    }
}