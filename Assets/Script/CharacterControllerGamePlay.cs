using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Com.LuisPedroFonseca.ProCamera2D;

public class CharacterControllerGamePlay : MonoBehaviour

{
    public ProCamera2D proCamera2D;
    public List<CharacterBase> characters;
    public static CharacterControllerGamePlay instance;

    public CharacterBase currentCharacter;

    public CharacterBase GetCharacterBase(CharacterType type)
    {
        foreach (var character in characters)
        {
            if (character.characterType == type)
            {
                return character;
            }
        }
        return null;
    }
    public Transform firstPoint;
    private void Awake()
    {
        instance = this;
}
    public void Start()
    {
        currentCharacter = Instantiate(GetCharacterBase(CharacterType.Small));
        currentCharacter.transform.position = firstPoint.position;
        proCamera2D.AddCameraTarget(currentCharacter.transform);

    }
    public void ChangeCharacter(CharacterType type)
    {
        if(currentCharacter.characterType == type)
        {
            Debug.Log("Same Character");
            return;
        }
        if (currentCharacter.characterType == CharacterType.Small)
        {
            var post = currentCharacter.transform.position;
            Destroy(currentCharacter.gameObject);
            currentCharacter = Instantiate(GetCharacterBase(CharacterType.Big));
            currentCharacter.transform.position = post;
            Debug.Log("Change Character");
            return;
            
        }

        if (currentCharacter.characterType == CharacterType.Big)
        {
            var post = currentCharacter.transform.position;
            Destroy(currentCharacter.gameObject);
            currentCharacter = Instantiate(GetCharacterBase(CharacterType.Special));
            currentCharacter.transform.position = post;
            Debug.Log("Change Character");
            return;
            
        }
    }

    public void HandleTakeDamage()
    {
        switch (currentCharacter.characterType)
        {
            case CharacterType.Small:
                Debug.Log("Small");
                break;
            case CharacterType.Big:
                var post = currentCharacter.transform.position;
                Destroy(currentCharacter.gameObject);
                currentCharacter = Instantiate(GetCharacterBase(CharacterType.Small));
                currentCharacter.transform.position = post;
                Debug.Log("Change Character");
                break;
            case CharacterType.Special:
                var post1 = currentCharacter.transform.position;
                Destroy(currentCharacter.gameObject);
                currentCharacter = Instantiate(GetCharacterBase(CharacterType.Big));
                currentCharacter.transform.position = post1;
                Debug.Log("Change Character");
                break;
        }
    }

    public void HandleTakeDamage(bool isDead)
    {
        Debug.Log("Death");
        Destroy(currentCharacter.gameObject);
    }

}
