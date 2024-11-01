using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyControl control = other.GetComponent<RubyControl>();
        if (control != null)
        {
            if (control.health < control.maxHealth)
            {
                control.ChangeHealth(1);
                Destroy(gameObject);
            }
        }
    }
}
