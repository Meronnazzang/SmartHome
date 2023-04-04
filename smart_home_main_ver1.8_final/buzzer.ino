#define NOTE_D4  294
#define NOTE_E4  330
#define NOTE_G4  392

const PROGMEM int melody_array[] = {NOTE_D4, NOTE_E4, NOTE_G4, NOTE_G4, NOTE_G4, NOTE_G4, NOTE_G4, NOTE_G4, NOTE_G4};
const PROGMEM int duration_tone_array[] = {4, 4, 8, 8, 16, 16, 16, 8, 8};

unsigned long timer0 = 0;

unsigned long tick_door_bell = 0;
int index = 0;
int melody = 0;
int duration_tone = 0;
int duration_total = 0;

int hz_fire = 300;
bool alt_fire = true;

int tick_water = 0;
bool alt_water = true;

void setup_buzzer()
{
    // CTC모드 - TCNT0 값이 0부터 증가하다가 OCR0A 값과 일치하면 0으로 떨어진 후, 다시 증가하는 계수 동작
    // T = (1/16000000) * (124+1) * 64 sec = 0.0005 sec = 0.5 ms
    // f = 1/T = 1/0.0005 Hz = 2000 Hz = 2 kHz
    TCNT0 = 0;                      // TCNT0 값을 0으로 초기화
    OCR0A = 124;                    // OCR0A 값을 124로 설정
    TCCR0A |= 1<<WGM01;             // CTC 모드 활성화
    TCCR0B |= 1<<CS01 | 1<<CS00;    // 64분주 설정  
    TIMSK0 |= 1<<OCIE0A;            // 비교일치 인터럽트 활성화

    pinMode(PIN_BUZZER_DOOR_BELL, OUTPUT);
    pinMode(PIN_BUZZER_FIRE, OUTPUT);
    pinMode(PIN_BUZZER_WATER, OUTPUT);
}

ISR(TIMER0_COMPA_vect)
{
    timer0++;
    switch(timer0 % 3)
    {
        case 0:
            if (buzz_sw)
            {
                if (tick_door_bell == duration_tone)
                {
                    noTone(PIN_BUZZER_DOOR_BELL);
                }
                if (tick_door_bell == duration_total)
                {
                    melody = pgm_read_word_near(melody_array + index);
                    tone(PIN_BUZZER_DOOR_BELL, melody);
                    duration_tone = 300 / pgm_read_word(duration_tone_array + index);
                    duration_total = duration_tone * 1.30;
                    index++;
                    tick_door_bell = 0;
                }
                tick_door_bell++;
                if (index >= 10)
                {
                    noTone(PIN_BUZZER_DOOR_BELL);
                    tick_door_bell = 0;
                    index = 0;
                    duration_tone = 0;
                    duration_total = 0;
                    buzz_sw = false;
                    //Serial.println("buzz off");
                }
            }
            else
            {
                noTone(PIN_BUZZER_DOOR_BELL);
            }
            break;
        case 1:
            if (buzz_fire)
            {
                //Serial.println("buzzer_fire on");
                tone(PIN_BUZZER_FIRE, hz_fire);
                if (alt_fire)
                {
                    hz_fire++;
                    if (hz_fire >= 750)
                        alt_fire = false;
                }
                else
                {
                    hz_fire--;
                    if (hz_fire <= 300)
                        alt_fire = true;
                }
            }
            else
            {
                noTone(PIN_BUZZER_FIRE);
            }
            break;
        case 2:
            if (buzz_water)
            {
                digitalWrite(PIN_BUZZER_WATER, HIGH);
                if (alt_water && (tick_water / 150) % 2 == 0)
                {
                    tone(PIN_BUZZER_WATER, 810);
                    alt_water = false;
                }
                else if (!alt_water && (tick_water / 150) % 2 == 1)
                {
                    tone(PIN_BUZZER_WATER, 910);
                    alt_water = true;
                }
                tick_water++;
            }
            else
            {
                digitalWrite(PIN_BUZZER_WATER, LOW);
                noTone(PIN_BUZZER_WATER);
            }
            break;
        default:
            break;
    }
}
