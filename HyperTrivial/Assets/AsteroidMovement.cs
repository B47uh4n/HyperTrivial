using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AsteroidMovement : MonoBehaviour
{

    [SerializeField] Transform Asteroid;
    [SerializeField] Transform Solar;
    [SerializeField] Transform Robot;
    [SerializeField] Transform Robot2;

    //asteroid 5.0 1.0 5.0

    // Start is called before the first frame update
    void Start()
    {

     if (Asteroid != null)
        {
            Asteroid.DORotate(new Vector3(360.0f, 360.0f, 0.0f), 5.0f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetRelative().SetEase(Ease.Linear);
            Asteroid.DOMove(new Vector3(5.0f, 1.0f, 5.0f), 3.5f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);

          
        }

        if (Solar != null)
        {
            Solar.DORotate(new Vector3(360.0f, 360.0f, 0.0f), 5.0f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetRelative().SetEase(Ease.Linear);
            Solar.DOMove(new Vector3(5.0f, 3.5f, 10.0f), 8.0f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
        }

        if (Robot != null)
        {
            Robot.DOMove(new Vector3(-0.6f, 0.0f, 31.0f), 20.0f);
        }

        if (Robot2 != null)
        {
            Robot2.DOMove(new Vector3(-0.6f, 0.0f, 67.0f), 30.0f);
        }
    }
     
}
