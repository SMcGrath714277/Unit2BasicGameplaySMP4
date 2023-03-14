using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetectCollisions : MonoBehaviour
{
    private GameInterface gameInterface;
    // Start is called before the first frame update
    void Start()
    {
        gameInterface = GameObject.Find("GameInterface").GetComponent<GameInterface>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameInterface.AddLives(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Animal"))
        {
            gameInterface.AddScore(1);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
