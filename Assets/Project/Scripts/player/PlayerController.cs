using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private bool isMoving = false;
    private Vector2 input;
    private Vector3 targetPos;

    private void Update()
    {
        if (!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            // Sadece tek yön (öncelik yatay)
            if (input.x != 0)
                input.y = 0;

            if (input != Vector2.zero)
            {
                targetPos = transform.position + new Vector3(input.x, input.y, 0);
                StartCoroutine(MoveToTarget());
            }
        }
    }

    private System.Collections.IEnumerator MoveToTarget()
    {
        isMoving = true;

        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }

        transform.position = targetPos;
        isMoving = false;
    }
}
