﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpaceMove : MonoBehaviour
{
    public Vector3[] positions;
    public Transform ObjectToMove;
    public float MoveSpeed = 8;
    Coroutine MoveIE;


    void Start()
    {
        StartCoroutine(moveObject());
    }

    void Update()
    {
  
    }

    IEnumerator moveObject()
    {
        for (int i = 0; i < positions.Length; i++)
        {
            MoveIE = StartCoroutine(Moving(i));
            yield return MoveIE;
        }
    }

    IEnumerator Moving(int currentPosition)
    {
        while (ObjectToMove.transform.position != positions[currentPosition])
        {
            ObjectToMove.transform.position = Vector3.MoveTowards(ObjectToMove.transform.position, positions[currentPosition], MoveSpeed * Time.deltaTime);
            yield return null;
        }


    }


}