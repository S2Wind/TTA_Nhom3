using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    [SerializeField] Vector3 pos;
    void Start()
    {
        this.gameObject.transform.localPosition = pos;
    }

}
