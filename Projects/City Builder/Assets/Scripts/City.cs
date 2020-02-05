using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour
{
    public int Cash { get; set; }
    public int Day { get; set; }
    public float PopulationCurrent { get; set; }
    public float PopulationCeiling { get; set; }
    public int JobsCurrent { get; set; }
    public int JobsCeiling { get; set; }
    public float Food { get; set; }

    public int[] buildingCounts = new int[3];

    private void Start()
    {
        buildingCounts[0] = 6;
        buildingCounts[1] = 1;
        buildingCounts[2] = 3;
        Cash = 10000;
        Food = 6;
        JobsCeiling = 10;
    }

    public void EndTurn()
    {
        Day++;
        CalculatePopulation();
        CalculateJobs();
        CalculateFood();
        CalculateCash();
        Debug.Log("Day ended. New day: " + Day);
        Debug.LogFormat("Jobs: {0}/{1}, Cash: {2}, Population: {3}/{4}, Food: {5}",
            JobsCurrent, JobsCeiling, Cash, PopulationCurrent, PopulationCeiling, Food);
    }

    public void CalculateJobs()
    {
        JobsCeiling = buildingCounts[2] * 10;
        JobsCurrent = Mathf.Min((int)PopulationCurrent, JobsCeiling);
    }

    public void CalculateCash()
    {
        Cash += JobsCurrent * 2;
    }

    public void CalculateFood()
    {
        Food += buildingCounts[1] * 4f;
    }

    public void CalculatePopulation()
    {
        PopulationCeiling = buildingCounts[0] * 5;

        if (Food >= PopulationCurrent && PopulationCurrent < PopulationCeiling)
        {
            Food -= PopulationCurrent * 0.25f;
            PopulationCurrent = Mathf.Min(PopulationCurrent += Food * 0.25f, PopulationCeiling);
        }
        else if (Food < PopulationCurrent)
        {
            PopulationCurrent -= (PopulationCurrent - Food) * 0.5f;
        }
    }
}
