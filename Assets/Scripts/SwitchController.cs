﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public DoorController door;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && LevelManager.instance.hasKey = true && Input.GetKeyDown(KeyCode.O))
        {
            door.KillDoor();
        }

    }
}
