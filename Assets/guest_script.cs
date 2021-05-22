﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guest_script : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(talking());
    }
    IEnumerator talking()
    {
        while (true)
        {
            float number = Random.Range(0.0f, 3.0f);
            anim.Play("guest_w");
            yield return new WaitForSeconds(number);
        }

    }
}
