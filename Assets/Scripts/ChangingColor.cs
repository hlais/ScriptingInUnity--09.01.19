using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ChangingColor : MonoBehaviour
{
    Renderer m_renderer;

    public void Start()
    {
        m_renderer = GetComponent<Renderer>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_renderer.material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
           m_renderer.material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_renderer.material.color = Color.blue;
        }

    }
    private void OnMouseEnter()
    {
        m_renderer.material.color = Color.clear;
    }
    private void OnMouseOver()
    {
        m_renderer.material.color = Color.black;
    }
    private void OnMouseExit()
    {
        m_renderer.material.color = Color.cyan;
    }
}