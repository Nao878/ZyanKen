using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject correct;

    public void Press()
    {
        correct.SetActive(true);
    }
}
