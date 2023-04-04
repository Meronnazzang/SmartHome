int before = 0;
bool buzz_sw = false;

void setup_door_bell()
{
    /*
    // Uno - 2번핀 = PD2 = INT0
    // Mega - 19번핀 = PD2 = INT2
    DDRD &= ~(1<<PD2);
    EIMSK |= 1<<INT2;   // INT0 활성화
    EICRA |= 2<<ISC20;  // falling edge 방식 사용
    */
    pinMode(19, INPUT_PULLUP);
}

void task_door_bell()
{
    int sw = digitalRead(19);
    Serial.print("sw: ");
    Serial.println(sw);
    if ((before == 0) && (sw == LOW))
    {
        buzz_sw = true;
        before = 1;
    }
    else if ((before == 1) && (sw == HIGH))
    {
        buzz_sw = false;
        before = 0;
    }
}

/*
ISR(INT2_vect)
{
    buzz_sw = true;
    Serial.println("sw_door_bell pressed");
}
*/
