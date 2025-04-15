using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_MaskUnit : Enemy
{

    private void Awake()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
    }
}
