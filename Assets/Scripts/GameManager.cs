using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance{ get; private set;}
    public int vida=10;
    public int pontos;
    //public GameObject bala;

    void Awake()
    {
        if (Instance==null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        //bala.GetComponent<GameObject>();
    }
    public GameManager getInstance() { return Instance; }
}
