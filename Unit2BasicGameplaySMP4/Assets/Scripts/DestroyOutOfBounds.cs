using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30;
    public float bottomBound = -10;
    public float sideBound = 30;
    private GameInterface gameInterface;

    // Start is called before the first frame update
    void Start()
    {
        gameInterface = GameObject.Find("GameInterface").GetComponent<GameInterface>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBound)
        {
            gameInterface.AddLives(-1);
            Destroy(gameObject);
        }
        else if(transform.position.x > sideBound)
        {
            gameInterface.AddLives(-1);
            Destroy(gameObject);
        }
        else if(transform.position.x < -sideBound)
        {
            gameInterface.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
