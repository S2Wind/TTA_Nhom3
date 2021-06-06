using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GameEditer : MonoBehaviour
{
    [SerializeField] Material Day;
    [SerializeField] Material Night;
    [MenuItem("DayNigh/SetDay")]
    [ContextMenu("SetDay")]
    void SetDay()
    {
        RenderSettings.skybox = Day;
    }
    [ContextMenu("SetNight")]
    void SetNight()
    {
        RenderSettings.skybox = Night;
    }
}
