using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Demo : MonoBehaviour {
    private ProjectManagerScript projectManager;
     

    public void Start()
    {
        projectManager = Component.FindObjectOfType<ProjectManagerScript>();

        Dictionary<BuildingProperty, MetricMapping> mappings = new Dictionary<BuildingProperty, MetricMapping>();

        List<string> metricNames = projectManager.currentProject.metricNames;

        mappings.Add(BuildingProperty.Height, new MetricMapping(metricNames[7], BuildingProperty.Height, new ValueConverter(0, 1, 0, 1, false), null));
        mappings.Add(BuildingProperty.Width, new MetricMapping(metricNames[10], BuildingProperty.Width, new ValueConverter(0, 1, 0, 1, false), null));
        mappings.Add(BuildingProperty.Red, new MetricMapping(metricNames[0], BuildingProperty.Red, new ValueConverter(0, 100, 0, 1, true), null));
        mappings.Add(BuildingProperty.Green, new MetricMapping(metricNames[0], BuildingProperty.Green, new ValueConverter(0, 100, 0, 1, true), null));
        mappings.Add(BuildingProperty.Blue, new MetricMapping(metricNames[0], BuildingProperty.Blue, new ValueConverter(0, 100, 0, 1, true), null));

        projectManager.OnMappingChanged(mappings);
    }

}
