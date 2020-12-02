using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{

    //1st num: mininum size of the box, 2nd num is the amount of lines before scrolling
    [TextArea(14, 10)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;


    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }

}
