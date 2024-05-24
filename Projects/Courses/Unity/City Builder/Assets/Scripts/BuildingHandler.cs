using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingHandler : MonoBehaviour
{
    [SerializeField] private City city;
    [SerializeField] private UIController uiController;
    [SerializeField] private Board board;
    [SerializeField] private GameObject Highlighter;
    [SerializeField] private Building[] buildings;
    [SerializeField] private Button[] buttons;
    private Building selectedBuilding;
    

    private void Update()
    {
        if (Input.GetMouseButton(0) && Input.GetKey(KeyCode.LeftShift) && selectedBuilding != null)
        {
            InteractWithBoard(0);
        }
        else if (Input.GetMouseButtonDown(0) && selectedBuilding != null)
        {
            InteractWithBoard(0);
        }

        if (Input.GetMouseButtonDown(1))
        {
            InteractWithBoard(1);
        }
    }

    void InteractWithBoard(int action)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 gridPosition = board.CalculateGridPosition(hit.point);

            if (!UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
            {
                if (action == 0 && board.CheckForBuildingAtPosition(gridPosition) == null)
                {
                    if (city.Cash >= selectedBuilding.cost)
                    {
                        city.HandleCash(-selectedBuilding.cost);
                        uiController.UpdateCityData();
                        city.buildingCounts[selectedBuilding.id]++;
                        board.AddBuilding(selectedBuilding, gridPosition);
                    }
                }
                else if (action == 1 && board.CheckForBuildingAtPosition(gridPosition) != null)
                {
                    city.HandleCash(board.CheckForBuildingAtPosition(gridPosition).cost/2);
                    board.RemoveBuilding(gridPosition);
                    uiController.UpdateCityData();
                }
            }
        }
    }

    public void EnableBuilder(int building)
    {
        if (selectedBuilding == buildings[building])
        {
            Highlighter.SetActive(false);
            selectedBuilding = null;
        }
        else
        {
            selectedBuilding = buildings[building];
            Highlighter.SetActive(true);
            Highlighter.transform.position = buttons[building].transform.position;
        }
    }
}
