using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanSetup : MonoBehaviour
{
    bool m_IsSpinning = false;

    public bool IsSpinning { get => m_IsSpinning; set => m_IsSpinning = value; }
    public int Index { get => index; set => index = value; }

    List<float> m_State = new List<float> { 5, 10, 15, 20, 0 };
    int index = 0;

    void FixedUpdate()
    {
        if (!IsSpinning) return;
        this.transform.Rotate(new Vector3(0, m_State[Index], 0));
    }
    public void ChangeState()
    {
        index++;
        if (index >= m_State.Count) index = 0;
        m_IsSpinning = true;
    }
}
