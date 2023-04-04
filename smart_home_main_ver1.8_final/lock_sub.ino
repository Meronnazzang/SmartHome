void setup_lock_sub()
{
    pinMode(PIN_CDS, INPUT);
    pinMode(PIN_RELAY_LOCK_SUB, OUTPUT);
}

void task_lock_sub()
{
    int cds = analogRead(PIN_CDS);
    Serial.println("C:" + String(cds));

    if (cds > 1000)
        digitalWrite(PIN_RELAY_LOCK_SUB, LOW);
    else
        digitalWrite(PIN_RELAY_LOCK_SUB, HIGH);
}
