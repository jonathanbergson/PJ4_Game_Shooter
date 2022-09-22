using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class Manager : MonoBehaviour
    {
        public Text pontuacao;
        public static Manager Instance { get; private set; }

        [SerializeField]private int _totalPoints;
        public int TotalPoints => _totalPoints;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }
        public void IncrementTotalPoints()
        {
            _totalPoints++;
            pontuacao.text = "" + _totalPoints;
        }
    }
}
