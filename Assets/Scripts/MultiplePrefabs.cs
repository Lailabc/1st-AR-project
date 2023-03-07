using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class MultiplePrefabs : MonoBehaviour
{
    public List<GameObject> Prefabs;
    private ARPlacementInteractable interactable;
    private int prefabIndex;
    private void Awake()
    {
        SetPrefabIndex();
        interactable = GetComponent<ARPlacementInteractable>();
        interactable.placementPrefab = Prefabs[prefabIndex];
    }
    private void SetPrefabIndex()
    {
        prefabIndex = Random.Range(0, Prefabs.Count);
    }
    public void ResetPrefab()
    {
        SetPrefabIndex();
        interactable.placementPrefab = Prefabs[prefabIndex];
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
