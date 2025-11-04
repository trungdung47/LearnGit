using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public bool isDead = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.GetComponent<CharacterBase>() != null)
            {
                if(isDead == false){
                {
                    isDead = true;
                    CharacterControllerGamePlay.instance.HandleTakeDamage(isDead);
                    Destroy(gameObject);
                }}

            }
        }
    }
}
