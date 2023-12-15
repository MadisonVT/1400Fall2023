using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehaviour : MatchBehaviour
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        colorIDDataListObj.SetCurrentColorRandomly();
        idObj = colorIDDataListObj.currentColor;
    }

    public void ChangeColor(SpriteRenderer colorRenderer)
    {
        var newColor = idObj as ColorID;

        colorRenderer.color = newColor.value;
    }
}
