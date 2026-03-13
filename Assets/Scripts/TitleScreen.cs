using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;

public class TitleScreen : MonoBehaviour
{

    public GameObject Player;
    public GameObject Bg;
    public GameObject Initiator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            initializeGame();
        }
    }

    private void initializeGame()
    {
        GameObject player = Instantiate(Player);
        GameObject background = Instantiate(Bg);
        GameObject initiator = Instantiate(Initiator);
        Destroy(gameObject);
    }

    
    public static void restart()
    {
        GameObject[] allObjects = FindObjectsOfType<GameObject>();
        foreach(GameObject obj in allObjects)
        {
            if (!obj.CompareTag("MainCamera"))
            {
                Destroy(obj);
            }
        }

    }
}
