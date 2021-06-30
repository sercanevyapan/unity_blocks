using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotCountText : MonoBehaviour
{

    public AnimationCurve scaleCurve;

    private CanvasGroup cg;

    private Text topText, bottomText;
    
    void Awake()
    {
        cg = GetComponent<CanvasGroup>();
        topText = transform.Find("TopText").GetComponent<Text>();
        bottomText = transform.Find("BottomText").GetComponent<Text>();
        transform.localScale = Vector3.zero;

    }

    public void SetTopText(string text)
    {
        topText.text = text;
    }

    public void SetBottomText(string text)
    {
        bottomText.text = text;
    }

    public void Flash()
    {
        cg.alpha = 1;
        transform.localScale = Vector3.zero;
        StartCoroutine(FlashRoutine());
    }

    IEnumerator FlashRoutine()
    {
        for (int i = 0; i <= 60; i++)
        {
            transform.localScale = Vector3.one * scaleCurve.Evaluate((float)i/50);
            if (i >= 40)
            {
                cg.alpha = (float)(60 - i) / 20;
            }
            yield return null;
        }
        yield break;
    }

    
}
