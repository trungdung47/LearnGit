using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
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
                    CharacterControllerGamePlay.instance.ChangeCharacter(CharacterType.Special);
                    Destroy(gameObject);
                }

            }
        }
    }
}
