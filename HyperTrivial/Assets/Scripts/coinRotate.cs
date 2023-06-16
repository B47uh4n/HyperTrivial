using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class coinRotate : MonoBehaviour
{

    void Start()
    {
        transform.DORotate(new Vector3(0.0f, 360.0f, 0.0f), 3.0f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart);
    }

}