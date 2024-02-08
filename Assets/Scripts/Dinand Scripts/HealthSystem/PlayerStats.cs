using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public delegate void OnHealthChangedDelegate();
    public OnHealthChangedDelegate onHealthChangedCallback;

    #region Sigleton
    private static PlayerStats instance;
    public static PlayerStats Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<PlayerStats>();
            return instance;
        }
    }
    #endregion

    [SerializeField]
    private float health;
    [SerializeField]
    private float maxHealth;

    public GameObject SM;
    public GameObject gameOverScreen;
    public TextMeshProUGUI finalScore;

    public float Health { get { return health; } }

    public float MaxHealth { get { return maxHealth; } }

    public void Heal(float health)
    {
        this.health += health;
        ClampHealth();
    }

    public void TakeDamage(float dmg)
    {
        health -= dmg;
        ClampHealth();

        if(health == 0)
        {
            Time.timeScale = 0f;
            SM.GetComponent<ScoreScript>().SaveHighscore();
            gameOverScreen.SetActive(true);
            finalScore.text = "Score: " + SM.GetComponent<ScoreScript>().currentScore.ToString();
        }
    }

    void ClampHealth()
    {
        health = Mathf.Clamp(health, 0, maxHealth);

        if (onHealthChangedCallback != null)
            onHealthChangedCallback.Invoke();
    }
}
