using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BtnClickHandler : MonoBehaviour
{
    public TextMeshProUGUI buttonText;

    public void OnButtonClick()
    {
        buttonText.text = "I'm Click!";
    }
}


