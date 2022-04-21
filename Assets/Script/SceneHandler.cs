using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    private void OnMouseDown()
    {
        Application.LoadLevel(0);
    }

    private void OnMouseUp()
    {

    }
}
