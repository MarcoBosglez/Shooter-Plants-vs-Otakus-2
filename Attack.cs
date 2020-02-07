using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    [Range(0f, 10f)]
    [SerializeField] float speed = 1f;
  
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
