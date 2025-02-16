using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaManzana : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float damage = 50;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var huachi = otherCollider.GetComponent<Health>();
        var huachiCharacter = otherCollider.GetComponent<Attack>();

        if (huachi && huachiCharacter)
        {
            huachi.HitEnemy(Random.Range(45, 100));
            Destroy(gameObject);
        }
    }

}
