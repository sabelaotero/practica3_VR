using UnityEngine;
using TMPro;
public class VariableDisplayTMP : MonoBehaviour
{
    public TextMeshProUGUI tmpText;

    public int coins;
    public int health;

    void Start()
    {
        coins = contadorMonedas.coinCount;
        health = da�o.health;
    }

    void Update()
    {
        tmpText.text = "Monedas recogidas: " + coins.ToString() + " Vidas: " + health.ToString();
    }

}
