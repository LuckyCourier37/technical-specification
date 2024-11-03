using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHighlight : MonoBehaviour
{
   
    [SerializeField] private Material outlineMaterial;  // �������� � �������� �������
    private Material[] originalMaterials;               // ������������ ���������
    private Material[] outlineMaterials;                // ��������� � ��������
    private Renderer objRenderer;
    private Vector3 NativeSize;


    void Start()
    {
        NativeSize = gameObject.transform.localScale;

        objRenderer = GetComponent<Renderer>();

        // ��������� �������� ��������� � ������� ������ ��� �������
        originalMaterials = objRenderer.materials;
        outlineMaterials = new Material[originalMaterials.Length];

        // ��������� ������ �������
        for (int i = 0; i < originalMaterials.Length; i++)
        {
            outlineMaterials[i] = outlineMaterial;
        }
    }

    public void EnableOutline()
    {
        // ������������� ������ ���������� � ��������
        objRenderer.materials = outlineMaterials;
    }

    public void DisableOutline()
    {
        // ���������� �������� ���������
        objRenderer.materials = originalMaterials;
    }

    public Vector3 InitialSize()
    {
        return NativeSize;
    }
}
