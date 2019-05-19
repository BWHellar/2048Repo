using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MoveDirection
{
    Right, Left, Up, Down
}

public class InputManager : MonoBehaviour
{

    private GameManager gm;

    void Awake()
    {
        gm = GameObject.FindObjectOfType<GameManager> ();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gm.Move(MoveDirection.Right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gm.Move(MoveDirection.Left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gm.Move(MoveDirection.Up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gm.Move(MoveDirection.Down);
        }
    }
}
