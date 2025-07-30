using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Oyuncuyla temas kuruldu, savaþa geçiliyor...");
            SceneManager.LoadScene("BattleScene");
        }
    }
}
