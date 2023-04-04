void setup_motion()
{
    // Mega - 18번핀 = PD3 = INT3
    DDRD &= ~(1<<PD3);
    EIMSK |= 1<<INT3;   // INT3 활성화
    EICRA |= 1<<ISC30;  // any edge 방식 사용

    pinMode(PIN_DOOR_LIGHT_R, OUTPUT);
    pinMode(PIN_DOOR_LIGHT_L, OUTPUT);
}

ISR(INT3_vect)
{
    if (PIND & 1<<PD3)
    {
        digitalWrite(PIN_DOOR_LIGHT_R, HIGH);
        digitalWrite(PIN_DOOR_LIGHT_L, HIGH);
    }
    else
    {
        digitalWrite(PIN_DOOR_LIGHT_R, LOW);
        digitalWrite(PIN_DOOR_LIGHT_L, LOW); 
    }
}
