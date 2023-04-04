#define THRESHOLD_WARNING 500
#define THRESHOLD_ESCAPE  650

bool buzz_water = false;
bool escape = false;

int water = 0;

//1회차 - max 720
//2~5회차 - max 700~720상회
//6~10회차 - max 일정하게 630까지 떨어짐
//11회~ - max 620 중반에서 머무름

void setup_water()
{
    pinMode(PIN_WATER, INPUT);
    pinMode(PIN_RELAY_LOCK_MAIN, OUTPUT);
    pinMode(PIN_RELAY_LOCK_SUB, OUTPUT);
}

void task_water()
{
    water = analogRead(PIN_WATER);

    Serial.println("W:" + String(water));

    if (water >= THRESHOLD_WARNING)
    {
        buzz_water = true;
        if (water >= THRESHOLD_ESCAPE)
        {
            escape = true;
            digitalWrite(PIN_RELAY_LOCK_MAIN, HIGH); 
            digitalWrite(PIN_RELAY_LOCK_SUB, HIGH); 
        }
        else
        {
            escape = false;
        }
    }
    else
    {
        buzz_water = false;
        escape = false;
    }
}
