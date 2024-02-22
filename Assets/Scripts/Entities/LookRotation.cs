using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookRotation : MonoBehaviour
{
    Transform tf;

    private void Start()
    {
        tf = transform;
    }

    private void Update()
    {
        Vector2 mousePos = Input.mousePosition;

        Vector3 target = Camera.main.ScreenToWorldPoint(mousePos);

        if(target.x < tf.position.x)
        {
            tf.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            tf.localScale = new Vector3(1, 1, 1);
        }
    }
}
