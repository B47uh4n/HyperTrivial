using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AsteroidMovement : MonoBehaviour
{

    [SerializeField] Transform Asteroid;
    [SerializeField] Transform Solar;

    //asteroid 5.0 1.0 5.0

    // Start is called before the first frame update
    void Start()
    {

     if (Asteroid != null)
        {
            Asteroid.DORotate(new Vector3(360.0f, 360.0f, 0.0f), 5.0f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetRelative().SetEase(Ease.Linear);
            Asteroid.DOMove(new Vector3(5.0f, 1.0f, 5.0f), 4.0f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);

          
        }

        if (Solar != null)
        {
            Solar.DORotate(new Vector3(360.0f, 360.0f, 0.0f), 5.0f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetRelative().SetEase(Ease.Linear);
            Solar.DOMove(new Vector3(5.0f, 1.0f, 13.0f), 8.0f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
        }

    }
     
}
