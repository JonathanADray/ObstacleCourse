using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // [SerializeField] allows variable to be accessed in inspector in unity
    public float yValue = 0.0f;
    public float moveSpeed = 17.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();  
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move around");
        Debug.Log("Dodge the Obstacles");
    }

    void MovePlayer()
    {
        //adding Time.deltaTime works out the framerate of a given pc so it moves the same speed on fast and slow pc's
        // !Frame Rate Independent!
        float xValue= Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue= Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue,yValue,zValue);
    }
}
