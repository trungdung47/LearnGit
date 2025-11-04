using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BrickType
{
    Normal,
    Coin,
    GreenMushRoom,
    RedMushRoom,
    Flower,
}

public class Brick : MonoBehaviour
{
    public BrickType brickType;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switch (brickType)
            {
                case BrickType.Normal:
                    break;
                case BrickType.Coin:
                    break;
                case BrickType.GreenMushRoom:
                    break;
                case BrickType.RedMushRoom:
                    break;
                case BrickType.Flower:
                    break;
            }
        }
    }

}
        


