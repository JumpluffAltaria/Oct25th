using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCooldown : MonoBehaviour
{
    public Button button;
    public float cooldownDuration = 5.0f;
    private Color originalColor;
    private bool isCoolingDown = false;
    private float cooldownTimer = 0;

    void Start()
    {
        originalColor = button.image.color;
        button.onClick.AddListener(StartCooldown);
    }

    void Update()
    {
        if (isCoolingDown)
        {
            cooldownTimer += Time.deltaTime;
            float progress = cooldownTimer / cooldownDuration;
            button.image.color = Color.Lerp(Color.red, originalColor, progress);

            if (cooldownTimer >= cooldownDuration)
            {
                isCoolingDown = false;
                cooldownTimer = 0;
                button.image.color = originalColor;
            }
        }
    }

    void StartCooldown()
    {
        if (!isCoolingDown)
        {
            isCoolingDown = true;
        }
    }
}
