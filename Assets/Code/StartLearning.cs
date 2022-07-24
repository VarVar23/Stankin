using UnityEngine;

public class StartLearning : MonoBehaviour
{
    [SerializeField] private GameObject[] _texts;
    private int _index = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _index + 1 < _texts.Length)
        {
            _texts[_index].SetActive(false);
            _texts[_index + 1].SetActive(true);
            _index++;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && _index + 1 == _texts.Length)
        {
            _texts[_index].SetActive(false);
        }
    }
}
