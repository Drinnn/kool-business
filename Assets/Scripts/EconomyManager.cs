using BayatGames.SaveGameFree;
using UnityEngine;

public class EconomyManager : MonoBehaviour
{
    public static EconomyManager Instance;

    private string MONEY_SAVE_KEY = "MONEY";

    private int _money;

    public int Money
    {
        get => _money;
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        if (SaveGame.Exists(MONEY_SAVE_KEY))
        {
            _money = SaveGame.Load<int>(MONEY_SAVE_KEY);
        }
    }

    public void AddMoney(int amount)
    {
        _money += amount;
        SaveGame.Save(MONEY_SAVE_KEY, _money);
    }
}