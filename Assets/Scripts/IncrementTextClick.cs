using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IncrementTextClick : MonoBehaviour
{
    public GameObject textObject;

    public void Increment()
    {
        if (textObject is not null)
        {
            TextMeshProUGUI textComponent = textObject.GetComponent<TextMeshProUGUI>();
            if (textComponent is not null)
            {
                int parsedInt = 0;
                int.TryParse(textComponent.text.Trim(), out parsedInt);

                textComponent.text = (++parsedInt).ToString();
            }
        }
    }
}
