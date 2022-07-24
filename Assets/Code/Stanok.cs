using UnityEngine;

public class Stanok : MonoBehaviour
{
    [SerializeField] private GameObject[] _texts;
    private int _index = 0;
    private bool _trigger;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            _texts[_index].SetActive(true);
            _trigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _trigger = false;
            for(int i = 0; i < _texts.Length; i++)
            {
                _texts[i].SetActive(false);
                _index = 0;
            }
        }
    }

    private void Update()
    {
        if (_trigger == false) return;
        Debug.Log(_trigger);

        Debug.Log(_index + "  " + _texts.Length);
        if (Input.GetKeyDown(KeyCode.Space) && _index + 1 < _texts.Length)
        {
            _texts[_index].SetActive(false);
            _texts[_index + 1].SetActive(true);
            _index++;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && _index + 1 == _texts.Length)
        {
            _texts[_index].SetActive(false);
        }
    }
}
