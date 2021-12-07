using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class FadeInOut : MonoBehaviour
{
    public bool enableFadeIn = true, enableAutoFadeOut = true;

    public float delay, fadeoutTime, fadeinTime, maxFadeIn = 1, maxFadeOut = 0;
    float currentTime = 0, fadeTime = 1;
    bool isFadeOut = true;

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= delay && isFadeOut && enableAutoFadeOut)
            InvokeRepeating("fadeOut", 0, .01f);
    }

    public void fadeInInvoke()
    {
        if (!IsInvoking("fadeIn"))
            InvokeRepeating("fadeIn", 0, .01f);
    }

    public void fadeOutInvoke()
    {
        if (!IsInvoking("fadeOut"))
            InvokeRepeating("fadeOut", 0, .01f);
    }

    private void fadeIn()
    {
        CancelInvoke("fadeOut");
        currentTime = 0;
        var cg = GetComponent<CanvasGroup>();
        cg.blocksRaycasts = true; //enables the buttons to be pressed

        cg.alpha = Mathf.Clamp((fadeTime += Time.deltaTime) / fadeinTime, cg.alpha, maxFadeIn);
        if (GetComponent<CanvasGroup>().alpha >= maxFadeIn)
        {
            isFadeOut = true;
            fadeTime = fadeoutTime;
            GetComponent<CanvasGroup>().alpha = maxFadeIn;
            GetComponent<CanvasGroup>().blocksRaycasts = true;
            CancelInvoke("fadeIn");
        }
    }

    private void fadeOut()
    {
        isFadeOut = false;

        var cg = GetComponent<CanvasGroup>();

        cg.alpha = Mathf.Clamp((fadeTime -= Time.deltaTime) / fadeoutTime, maxFadeOut, cg.alpha);
        if (GetComponent<CanvasGroup>().alpha <= maxFadeOut)
        {
            cg.blocksRaycasts = false; //block the buttons from being pressed
            fadeTime = 0;
            GetComponent<CanvasGroup>().alpha = maxFadeOut;
            GetComponent<CanvasGroup>().blocksRaycasts = false;
            CancelInvoke("fadeOut");
        }
    }
}