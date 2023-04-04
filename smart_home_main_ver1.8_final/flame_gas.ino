bool buzz_fire = false;

void setup_flame_gas()
{
    pinMode(PIN_RELAY_FAN, OUTPUT);
    pinMode(PIN_GAS, INPUT);
    pinMode(PIN_FLAME, INPUT);
    pinMode(PIN_LED_SPRINKLER, OUTPUT);
}

void task_flame_gas()
{
    int flame = analogRead(PIN_FLAME);
    int gas = analogRead(PIN_GAS);

    Serial.println("G:" + String(gas));
    Serial.println("F:" + String(flame));
    
    if (flame < 980)
    {
        digitalWrite(PIN_LED_SPRINKLER, HIGH);
        buzz_fire = true;
    }
    else
    {
        digitalWrite(PIN_LED_SPRINKLER, LOW);
        
        if (gas > 400)
        {
            digitalWrite(PIN_RELAY_FAN, HIGH);
            buzz_fire = true;
        }
        else
        {
            digitalWrite(PIN_RELAY_FAN, LOW);
            buzz_fire = false;
        }
    }
}
