using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceMovement : MonoBehaviour
{
    public float maxSize;
    public float growFactor;
    public float waitTime;

    public float maxRotation;
    public Vector3 from = new Vector3(0f, 0f, -1.8f);
    public Vector3 to = new Vector3(0f, 0f, 1.8f);
    public float speed = 0.1f;

    void Start()
    {
        StartCoroutine(Scale());
    }

    void Update()
    {
        //float t = Mathf.PingPong(Time.time * speed * 2.0f, 1.0f);
        float t = (Mathf.Sin(Time.time * speed * Mathf.PI * 2.0f) + 1.0f) / 2.0f;
        transform.eulerAngles = Vector3.Lerp(from, to, t);
    }

    IEnumerator Scale()
    {
        float timer = 0;

        while (true)
        {
            // we scale all axis, so they will have the same value, 
            // so we can work with a float instead of comparing vectors
            while (maxSize > transform.localScale.x)
            {
                timer += Time.deltaTime;
                transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
                yield return null;
            }
            // reset the timer

            yield return new WaitForSeconds(waitTime);

            timer = 0;
            while (1 < transform.localScale.x)
            {
                timer += Time.deltaTime;
                transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
                yield return null;
            }

            timer = 0;
            yield return new WaitForSeconds(waitTime);
        }
    }


   /* IEnumerator Rotate()
    {
        float timer = 0;
        Vector3 newRotationAngles = transform.rotation.eulerAngles;

        while (true)
        {
            while (maxRotation > transform.localRotation.z)
            {
                timer += Time.deltaTime;
                //transform.rotation.z += Quaternion.Euler(0, 0, 0.1f); //* Time.deltaTime * growFactor;
                newRotationAngles.z += 50;
                transform.rotation = Quaternion.Euler(newRotationAngles);
                yield return null;
            }
            
            // reset the timer

            yield return new WaitForSeconds(waitTime);

            timer = 0;
            while (1 < transform.localScale.x)
            {
                timer += Time.deltaTime;
                //transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
                newRotationAngles.z -= 50;
                transform.rotation = Quaternion.Euler(newRotationAngles);
                yield return null;
            }

            timer = 0;
            yield return new WaitForSeconds(waitTime);          
        }
    }

    */
}