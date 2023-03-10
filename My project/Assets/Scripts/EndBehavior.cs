using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBehavior : MonoBehaviour
{
    public GameManager gamemanager;
    void OnTriggerEnter ()
    {
        gamemanager.CompleteLevel();
    }
}
