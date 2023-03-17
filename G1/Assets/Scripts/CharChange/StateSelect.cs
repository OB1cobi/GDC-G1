using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSelect : MonoBehaviour
{

    public static StateSelect instance { get; private set; }

    public GameObject[] characters;
    public Camera[] camera;

    public enum State
    {
        red,
        blue,
        green,
        black, 
        white,
        board
    };

    public State state;

    void Start()
    {
        state = State.red;
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }




    public GameObject GetObjectToMove()
    {
        if (state == State.red)
        {
            return characters[1];
        }

        if (state == State.blue)
        {
            return characters[2];
        }

        if (state == State.green)
        {
            return characters[3];
        }

        if (state == State.black)
        {
            return characters[4];
        }

        if (state == State.white)
        {
            return characters[0];
        }

        if (state == State.board)
        {
            return characters[5];
        }

        return characters[0];
    }

    public Camera GetCamToMove()
    {
        if (state == State.red)
        {
            return camera[1];
        }

        if (state == State.blue)
        {
            return camera[2];
        }

        if (state == State.green)
        {
            return camera[3];
        }

        if (state == State.black)
        {
            return camera[4];
        }

        if (state == State.white)
        {
            return camera[0];
        }

        if (state == State.board)
        {
            return camera[5];
        }

        return camera[0];
    }

}
