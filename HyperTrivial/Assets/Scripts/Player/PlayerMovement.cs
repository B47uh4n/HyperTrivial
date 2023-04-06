using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float limitValue;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MovePlayer();
        }
    }

    private void MovePlayer()
    {
        float halfScreen = Screen.width / 2;
        float xPos = (Input.mousePosition.x - halfScreen) / halfScreen;
        float finalXPos = Mathf.Clamp(xPos * limitValue, -limitValue, limitValue);

        playerTransform.localPosition = new Vector3(finalXPos, 0, 0);
    }
}
