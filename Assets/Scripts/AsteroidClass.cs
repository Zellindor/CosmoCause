using UnityEngine;

public class AsteroidClass : MonoBehaviour
{
    float speed;
    Vector2 travelDir;
    private Camera _camera;
    public GameObject titleScreen;

    void Start()
    {
        speed = Random.Range(1.5f, 4f);
        _camera = Camera.main;

        int edge = Random.Range(1, 5);
        Vector2 spawnPos;

        float camHeight = _camera.orthographicSize;
        float camWidth = camHeight * _camera.aspect;

        if (edge == 1)
            spawnPos = new Vector2(Random.Range(-camWidth, camWidth), camHeight);
        else if (edge == 2)
            spawnPos = new Vector2(Random.Range(-camWidth, camWidth), -camHeight);
        else if (edge == 3)
            spawnPos = new Vector2(-camWidth, Random.Range(-camHeight, camHeight));
        else
            spawnPos = new Vector2(camWidth, Random.Range(-camHeight, camHeight));

        transform.position = spawnPos;
        travelDir = (Vector2.zero - spawnPos).normalized;
        Destroy(gameObject, 15f);
    }

    void Update()
    {
        transform.position += (Vector3)(travelDir * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Player"))
        {
            GameObject restart = Instantiate(titleScreen);
            TitleScreen.restart();
        }
    }
}