using UnityEngine;

public class AsteroidClass : MonoBehaviour
{

    int speed;
    Vector2 spawnPos;
    private Camera _camera;

    public AsteroidClass()
    {
        speed = 1;
        Vector2 screenPosition = _camera.WorldToScreenPoint(transform.position);

        if(Random.Range(1,5) == 1)
        {

        }
        else if (Random.Range(1,5) == 2)
        {

        }
        else if (Random.Range(1,5) == 3)
        {

        }
        else if (Random.Range(1,5) == 4)
        {

        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
