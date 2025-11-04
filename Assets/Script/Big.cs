using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big : CharacterBase
{
    public override void Init()
    {
        
    }

    public override void Jump()
    {
        base.Jump();
        Smash();
    }

    public override void Move()
    {
        base.Move();
    }
    public void Smash()
    {

    }
}
