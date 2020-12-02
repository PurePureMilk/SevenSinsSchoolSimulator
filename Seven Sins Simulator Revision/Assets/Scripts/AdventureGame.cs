using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
   

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    // Use this for initialization
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates(); // OR State[] instead of var
        for (int index = 0; index < nextStates.Length; index++)
        {
            // @index = 0: keypress 1 plus zero corresponds to our first state

            /* @next increment index = 1: out index is up to 1 
            and there will be Alpha One plus one that will be a key press of two?*/

            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }

            Debug.Log(state);
        }
        textComponent.text = state.GetStateStory();


        /*
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        } else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        textComponent.text = state.GetStateStory();
        Debug.Log(state);
        */
    }
}
