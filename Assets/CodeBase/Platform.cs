using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;//поле для задання висоти стрибка

    private void OnCollisionEnter2D(Collision2D collision)//коли торкнувся будь-якого об'єкту
    {
        if (collision.relativeVelocity.y <= 0f)//якщо падає, або зупинився
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();//отримує посилання на фізику об'єкта якого торкнулися
            if (rb != null)//якщо посилання на фізику є
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);//надаємо імпульс об'єкту до якого доторкнулися
            }
        }
    }
}
