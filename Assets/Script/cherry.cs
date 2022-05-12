using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cherry : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("GatotKaca"))
        {
            print("cherry diambil");
            Destroy(gameObject);
            cherryscore.hitungCherry += 50;
        }
    }
}