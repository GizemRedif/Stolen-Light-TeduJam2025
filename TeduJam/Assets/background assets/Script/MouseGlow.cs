using UnityEngine;
using UnityEngine.UI;

public class MouseGlow : MonoBehaviour
{
    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        Vector2 mousePosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            transform.parent as RectTransform, 
            Input.mousePosition, 
            null, 
            out mousePosition);

        rectTransform.anchoredPosition = mousePosition;
    }
}
