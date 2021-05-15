using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSetup : MonoBehaviour
{
    public void ChangeState()
    {
        this.GetComponent<Light>().enabled = !this.GetComponent<Light>().enabled;
    }
}
