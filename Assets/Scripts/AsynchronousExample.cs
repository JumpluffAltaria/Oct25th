using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsynchronousExample : MonoBehaviour
{
    [SerializeField]
    private Button makeSandwichButton;

    [SerializeField]
    private Button cutCucumberButton;
    [SerializeField]
    private Button cutOliveButton;
    [SerializeField]
    private Button cutTomatoButton;
    [SerializeField]
    private Button spreadBreadButton;
    [SerializeField]
    private Button grateCheeseButton;
    [SerializeField]
    private Button selectHamButton;

    private bool cucumberCut = false;
    private bool oliveCut = false;
    private bool tomatoCut = false;
    private bool breadSpread = false;
    private bool cheeseGrated = false;
    private bool hamSelected = false;

    private void Start()
    {
        cutCucumberButton.onClick.AddListener(StartCuttingCucumber);
        cutOliveButton.onClick.AddListener(StartCuttingOlive);
        cutTomatoButton.onClick.AddListener(StartCuttingTomato);
        spreadBreadButton.onClick.AddListener(StartSpreadingBread);
        grateCheeseButton.onClick.AddListener(StartGratingCheese);
        selectHamButton.onClick.AddListener(StartSelectingHam);

        makeSandwichButton.onClick.AddListener(MakeSandwich);
    }

    public void StartCuttingCucumber()
    {
        StartCoroutine(CutCucumber());
    }

    public void StartCuttingOlive()
    {
        StartCoroutine(CutOlive());
    }

    public void StartCuttingTomato()
    {
        StartCoroutine(CutTomato());
    }

    public void StartSpreadingBread()
    {
        StartCoroutine(SpreadBread());
    }

    public void StartGratingCheese()
    {
        StartCoroutine(GrateCheese());
    }

    public void StartSelectingHam()
    {
        StartCoroutine(SelectHam());
    }

    IEnumerator CutCucumber()
    {
        yield return new WaitForSeconds(6);
        cucumberCut = true;
        Debug.Log("Cucumber cutting done");
    }

    IEnumerator CutOlive()
    {
        yield return new WaitForSeconds(6);
        oliveCut = true;
        Debug.Log("Olive slicing done");
    }

    IEnumerator CutTomato()
    {
        yield return new WaitForSeconds(6);
        tomatoCut = true;
        Debug.Log("Tomato slicing done");
    }

    IEnumerator SpreadBread()
    {
        yield return new WaitForSeconds(6);
        breadSpread = true;
        Debug.Log("Bread slicing done");
    }

    IEnumerator GrateCheese()
    {
        yield return new WaitForSeconds(6);
        cheeseGrated = true;
        Debug.Log("Cheese grating done");
    }

    IEnumerator SelectHam()
    {
        yield return new WaitForSeconds(6);
        hamSelected = true;
        Debug.Log("Ham selecting done");
    }

    public void MakeSandwich()
    {
        if (cucumberCut && oliveCut && tomatoCut && breadSpread && cheeseGrated && hamSelected)
        {
            Debug.Log("Making a sandwich done");
        }
        else
        {
            Debug.Log("Not all ingredients were ready.");
        }
    }
}
