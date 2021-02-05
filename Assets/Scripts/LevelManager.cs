using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * The LevelManager from the Week 6 Lecture
 */
public class LevelManager : MonoBehaviour {

    public static LevelManager instance;
    public KeyController keyController;
    public SwitchController switchController;
    public DoorController doorController;

    public bool hasKey = false;

    private void Awake()
    {
        // set the instance property/variable to this object
        instance = this;
        hasKey = false;

    }   


}

  
