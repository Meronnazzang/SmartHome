void setup_led_bar()
{ 
    pinMode(PIN_PWM_LED_BAR, OUTPUT);   // PWM 발생 핀
    pinMode(PIN_RELAY_LED_BAR, OUTPUT); // Relay Signal 제어 핀
}

void task_led_bar()
{
    if(Serial.available())
    {
        char a = Serial.read();
        //Serial.println(a);
        
        switch(a)
        {
            case '0':
                digitalWrite(PIN_RELAY_LED_BAR, LOW);
                analogWrite(PIN_PWM_LED_BAR, 0);
                break;
            case '1':
                digitalWrite(PIN_RELAY_LED_BAR, HIGH);
                analogWrite(PIN_PWM_LED_BAR, 25);
                break;
            case '2':
                digitalWrite(PIN_RELAY_LED_BAR, HIGH);
                analogWrite(PIN_PWM_LED_BAR, 50);
                break;
            case '3':
                digitalWrite(PIN_RELAY_LED_BAR, HIGH);
                analogWrite(PIN_PWM_LED_BAR, 75);
                break;
            case '4':
                digitalWrite(PIN_RELAY_LED_BAR, HIGH);
                analogWrite(PIN_PWM_LED_BAR, 100);
                break;
            case '5':
                digitalWrite(PIN_RELAY_LED_BAR, HIGH);
                analogWrite(PIN_PWM_LED_BAR, 125);
                break;
            case '6':
                digitalWrite(PIN_RELAY_LED_BAR, HIGH);
                analogWrite(PIN_PWM_LED_BAR, 150);
                break;
            case '7':
                digitalWrite(PIN_RELAY_LED_BAR, HIGH);
                analogWrite(PIN_PWM_LED_BAR, 175);
                break;
            case '8':
                digitalWrite(PIN_RELAY_LED_BAR, HIGH);
                analogWrite(PIN_PWM_LED_BAR, 200);
                break;
            case '9':
                digitalWrite(PIN_RELAY_LED_BAR, HIGH);
                analogWrite(PIN_PWM_LED_BAR, 255);
                break;
            default:
                break;
        }
    } 
}
