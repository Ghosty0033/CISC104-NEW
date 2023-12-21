using System;

public class Distance
{
    private float speed;
    private float time;

    public Distance()
    {
        // Default values for distance.
        speed = 0f;
        time = 0f;
    }

    public Distance(float newSpeed, float newTime)
    {
        // Should consider testing for positive numbers before accepting the parameters

        speed = newSpeed;
        time = newTime;
    }

    public float GetDistance()
    {
        return speed * time;
    }

    public float GetSpeed()
    {
        return speed;
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public float GetTime()
    {
        return time;
    }

    public void SetTime(float newTime)
    {
        time = newTime;
    }
}

