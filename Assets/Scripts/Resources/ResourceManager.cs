using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] woodTreePrefab;

    [SerializeField]
    private Transform FoodTreeParent;
    [SerializeField]
    private Transform woodTreeParent;
    [SerializeField]
    private Transform GoldTreeParent;
    [SerializeField]
    private Transform StoneTreeParent;

    [SerializeField]
    private ResourceSource[] resources;
    public ResourceSource[] Resources { get { return resources; } }

    public static ResourceManager instance;

    void Awake()
    {
        instance = this;
    }

    private void FindAllResource()
    {
        resources = FindObjectsOfType<ResourceSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        FindAllResource();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
