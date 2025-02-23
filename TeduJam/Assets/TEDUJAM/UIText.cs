using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    public TMP_Text flashlightCountText;

    public void UpdateUIText(int count)
    {
        if (flashlightCountText != null)
            flashlightCountText.text = count.ToString();
    }

}
