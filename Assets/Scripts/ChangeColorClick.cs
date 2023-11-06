using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeObjectColor(); //to define random start color
    }

    public void ChangeObjectColor()
    {

        Image image = gameObject.GetComponent<Image>();

        if (image is not null)
            image.color = UnityEngine.Random.ColorHSV();
    }
}
