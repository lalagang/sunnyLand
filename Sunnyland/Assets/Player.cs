using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

        transform.Translate(Input.GetAxis("Horizontal")* 15f * Time.deltaTime, 0f, 0f);

        Vector3 characterScale = transform.localScale;

        if (Input.GetAxis("Horizontal")  < 0)
        {
            characterScale.x = -10;
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 10;
        }
        transform.localScale = characterScale;
    }
}
