using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cute : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameOver)
        {
            this.transform.Rotate(0f, 800 * Time.deltaTime, 800 * Time.deltaTime);
            Debug.Log("개구리 돌아야해");
        }
    }
}
