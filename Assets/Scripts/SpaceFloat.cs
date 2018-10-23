using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpaceFloat : MonoBehaviour
{
    //rotation
    GameObject cube;
    public Transform center;
    public Vector3 axis = Vector3.up;
    public float rotationSpeed = 30.0f;
    //movement
    public Vector3[] positions;
    public Transform ObjectToMove;
    public float MoveSpeed = 8;
    Coroutine MoveIE;


    void Start()
    {
        cube = GameObject.FindWithTag("AstronautEscapeSuit");
        center = cube.transform;

        StartCoroutine(moveObject());
    }

    void Update()
    {
        transform.RotateAround(center.position, axis, rotationSpeed * Time.deltaTime);

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