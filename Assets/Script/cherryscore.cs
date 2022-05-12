using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cherryscore : MonoBehaviour
{
    // Start is called before the first frame update

    public static int hitungCherry;
    Text hitungCherryText;

    void Start()
    {
        hitungCherry = 0;
        hitungCherryText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hitungCherryText.text = hitungCherry.ToString();
    }
}
