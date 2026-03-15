class RemoteControlCar
{
    private int _metersDriven;
    // Might want to add separate battery percentage variable if you allow charging
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_metersDriven} meters";
    }

    public string BatteryDisplay()
    {
        return _metersDriven < 2000 ? $"Battery at {100 - _metersDriven / 20}%" : "Battery empty";
    }

    public void Drive()
    {
        if (_metersDriven < 2000) _metersDriven += 20;
    }
}
