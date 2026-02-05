using System.IO;
using UnityEngine;

[CreateAssetMenu(fileName = "Vehicle Settings", menuName = "Scriptable Objects/ Vehicle Settings")]
public class VehicleSettingsSO : ScriptableObject
{
    [Header("Wheel Paddings")]
    [SerializeField] private float _wheelsPaddingX;
    [SerializeField] private float _wheelsPaddingZ;

    [Header("Suspension")]
    [SerializeField] private float _springRestLenght;
    [SerializeField] private float _springStrength;
    [SerializeField] private float _springDamper;

    [Header("Handling")]
    [SerializeField] private float _steerAngle;



    public float WheelsPaddingX => _wheelsPaddingX;
    public float WheelsPaddingZ => _wheelsPaddingZ;
    public float SpringRestLength => _springRestLenght;
    public float SpringStrength => _springStrength;
    public float SpringDamper => _springDamper;
    public float SteerAngle => _steerAngle;

}