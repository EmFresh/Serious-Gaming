using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLight : MonoBehaviour
{
    public FadeInOut darkness;

    private void OnTriggerEnter(Collider other)
    {
        darkness.fadeOutInvoke();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
