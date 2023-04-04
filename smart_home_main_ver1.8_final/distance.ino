int count_dist = 0;
int count_buzz_delay = 0;
int count_dist_record = 0;
bool buzz_stranger_on = false;

void setup_distance()
{
    pinMode(PIN_ULTRA_TRIG, OUTPUT);
    pinMode(PIN_ULTRA_ECHO, INPUT);
    pinMode(PIN_BUZZER_STRANGER, OUTPUT);
}

void task_distance()
{
    digitalWrite(PIN_ULTRA_TRIG, HIGH);
    delayMicroseconds(10);
    digitalWrite(PIN_ULTRA_TRIG, LOW);
    
    long dur = pulseIn(PIN_ULTRA_ECHO, HIGH);
    double dist = (double)340 * (dur / 2) / 10000;

    Serial.println("D:" + String(dist));
    
    if (dist <= 10)
    {
        count_dist++;
        if(count_dist >= 50)
        {
            tone(PIN_BUZZER_STRANGER,523);
            //Serial.println("buzz_stranger on");
            buzz_stranger_on = true;
            count_dist_record = count_dist;
            count_buzz_delay = count_dist;
        }
    }
    else {
        //Serial.println("not detected");
        count_dist = 0;
        if (buzz_stranger_on)
        {
            count_buzz_delay++;
            if (count_buzz_delay >= count_dist_record + 12)
            {
                noTone(PIN_BUZZER_STRANGER);
                //Serial.println("buzz_stranger off");
                buzz_stranger_on = false;
                count_dist_record = 0;
                count_buzz_delay = 0;
            }
        }
    }

//    Serial.print("dist: ");
//    Serial.println(dist);
//    Serial.print("count_dist: ");
//    Serial.println(count_dist);
//    Serial.print("count_dist_record: ");
//    Serial.println(count_dist_record);
//    Serial.print("count_buzz_delay: ");
//    Serial.println(count_buzz_delay);
}
