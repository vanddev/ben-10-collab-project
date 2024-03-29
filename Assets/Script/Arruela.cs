﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arruela : MonoBehaviour
{
    Animator animator;
    public Monster monster;

    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetTrigger("left");
            monster.previous();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("right");
            monster.next();
        }
    }

}
