using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SynchronousExample : MonoBehaviour
{
    [SerializeField]
    private Button vegetableButton;

    [SerializeField]
    private Button eggButton;

    [SerializeField]
    private Button scrambleButton;

    public void StartVegetableProcessing()
    {
        StartCoroutine(CutVegetables());
        Debug.Log("Preparing vegetables...");
    }

    public void StartEggBeating()
    {
        StartCoroutine(BeatEggs());
        Debug.Log("Beating eggs...");

    }

    public void MakeScrambledEggs()
    {
        Debug.Log("Making scrambled eggs completed");
    }

    IEnumerator CutVegetables()
    {
        yield return new WaitForSeconds(12);
        Debug.Log("Preparing vegetables completed");
    }

    IEnumerator BeatEggs()
    {
        yield return new WaitForSeconds(12);
        Debug.Log("Beating eggs completed");
    }
}
