using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSetup : MonoBehaviour
{
    [SerializeField] GameObject[] m_Light;
    [SerializeField] GameObject m_Fan;

    public void TurnLight()
    {
        foreach (var i in m_Light)
            i.GetComponent<LightSetup>().ChangeState();
    }

    public void TurnFan()
    {
        m_Fan.GetComponent<FanSetup>().ChangeState();
    }
}
