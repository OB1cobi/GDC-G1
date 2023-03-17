using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSelect : MonoBehaviour
{
 public enum State
    {
        red,
        blue
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

    public void SwitchChar(State _state)
    {
        if (_state == State.red)
        {
            state = State.red;
            //movement 
        }

        if (_state == State.blue)
        {
            state = State.blue;
            //movement 
        }

        if (_state == State.green)
        {
            state = State.green;
            //movement 
        }

        if (_state == State.black)
        {
            state = State.black;
            //movement 
        }

        if (_state == State.white)
        {
            state = State.white;
            //movement 
        }

        if (_state == State.board)
        {
            state = State.board;
            //movement 
        }
    }

}
