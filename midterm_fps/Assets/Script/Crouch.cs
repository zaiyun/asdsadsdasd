﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    CapsuleCollider characterCollider;
    // Start is called before the first frame update
    void Start()
    {
        characterCollider = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            characterCollider.height = 1;
        }
        else
        {
            if (characterCollider.height <= 2) {
                characterCollider.height += 0.25f;
            }

        }
    }
}
