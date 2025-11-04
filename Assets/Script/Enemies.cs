using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public bool wasActive = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.GetComponent<CharacterBase>() != null)
            {
                if (wasActive == false)
                {
                    wasActive = true;
                    CharacterControllerGamePlay.instance.HandleTakeDamage();
                    Destroy(gameObject);
                }

            }
        }
    }
}
